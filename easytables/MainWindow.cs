using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using Gtk;
using Pango;


public partial class MainWindow : Gtk.Window
{

    //global variables
    private List<string> rules;

    //para crear fuentes
    public static FontDescription Font(string Family, int Size, Pango.Style Sty = Pango.Style.Normal)
    {
        var F = new FontDescription
        {
            Family = Family,
            Size = Convert.ToInt32(Size * Pango.Scale.PangoScale),
            Style = Sty
        };
        return F;
    }



    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        rules = new List<string>();

        //asignar fuente de titulo al titulo
        var font_title = Font("Verdana", 24);
        var font_littletitle = Font("Verdana", 12);
        label_gen.ModifyFont(font_littletitle);
        title_rules.ModifyFont(font_littletitle);
        label_STATES.ModifyFont(font_littletitle);
        titlelbl.ModifyFont(font_title);


        //anyadir interfaces de red
        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
        foreach (NetworkInterface adapter in adapters) {
            comboboxentry_interfaces.AppendText(adapter.Name);
            comboboxentry_interface_output.AppendText(adapter.Name);
        }

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    //messsage box
    void ShowMessage(Window parent, string title, string message)
    {
        Dialog dialog = null;
        try
        {
            dialog = new Dialog(title, parent,
                DialogFlags.DestroyWithParent | DialogFlags.Modal,
                ResponseType.Ok);
            dialog.VBox.Add(new Label(message));
            dialog.ShowAll();

            dialog.Run();
        }
        finally
        {
            if (dialog != null)
                dialog.Destroy();
        }
    }


    //cuando se genere el bash
    protected void OnGenbuttonClicked(object sender, EventArgs e)
    {
        // get general rules 
        string input_base = comboboxentry_input.ActiveText;
        string output_base = comboboxentry_output.ActiveText;
        string forward_base = comboboxentry_forward.ActiveText;

        //get /home/user/easytables.sh
        string user_folder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string file_path = user_folder + "/easytables.sh";

        //make it bash
        File.WriteAllText(file_path, "#/bin/sh" + Environment.NewLine);

        //flush anterior rules
        File.AppendAllText(file_path, "sudo iptables -F" + Environment.NewLine);
        File.AppendAllText(file_path, "sudo iptables --delete-chain" + Environment.NewLine);

        //write general rules on first file
        File.AppendAllText(file_path, "sudo iptables -P INPUT " + input_base + Environment.NewLine);
        File.AppendAllText(file_path, "sudo iptables -P OUTPUT " + output_base + Environment.NewLine);
        File.AppendAllText(file_path, "sudo iptables -P FORWARD " + forward_base + Environment.NewLine);

        //add rules
        foreach (string rule in rules) {
            File.AppendAllText(file_path, rule + Environment.NewLine);
        }

        //allow x11 forwarding
        if (checkbutton_x11.Active)
        {
            File.AppendAllText(file_path, "sudo iptables -A INPUT -p tcp --dport 6000:6063 -j ACCEPT" + Environment.NewLine);
            File.AppendAllText(file_path, "sudo iptables -A OUTPUT -p tcp --sport 6000:6063 -j ACCEPT" + Environment.NewLine);
        }



        //loopback
        if (checkbutton_loopback.Active) {
            File.AppendAllText(file_path, "sudo iptables -A INPUT -i lo -j ACCEPT" + Environment.NewLine);
            File.AppendAllText(file_path, "sudo iptables -A OUTPUT -o lo -j ACCEPT" + Environment.NewLine);
        }

        ShowMessage(this, "Alert Box", "Bash script generated in: " + file_path);
    }

    //get strings for command
    private string getSourceIp(string sip) {

        string temp_sip;

        if (!sip.Equals(""))
        {
            temp_sip = "-s " + sip;
        }
        else
        {
            temp_sip = "";
        }

        return temp_sip;
    }

    //get source port
    private string getSourcePort(string sport)
    {

        string temp_sport;

        if (!sport.Equals(""))
        {
            temp_sport = "--sport " + sport;
        }
        else
        {
            temp_sport = "";
        }

        return temp_sport;
    }

    //get destination ip
    private string getDestinationIp(string dip)
    {

        string temp_dip;

        if (!dip.Equals(""))
        {
            temp_dip = "-d " + dip;
        }
        else
        {
            temp_dip = "";
        }

        return temp_dip;
    }

    //get destoination port string
    private string getDestinationPort(string dport)
    {

        string temp_dport;

        if (!dport.Equals(""))
        {
            temp_dport = "--dport " + dport;
        }
        else
        {
            temp_dport = "";
        }

        return temp_dport;
    }


    //get input interface string
    private string getInputInterface() {

        string cadena = "";
        string interficie = comboboxentry_interfaces.ActiveText;

            if (!interficie.Equals("none")){

            cadena = "-i " + interficie;

            }
        

        return cadena;

    }

    //get output interface
    private string getOutputInterface()
    {

        string cadena = "";
        string interficie = comboboxentry_interface_output.ActiveText;

        if (!interficie.Equals("none"))
        {

            cadena = "-o " + interficie;

        }


        return cadena;

    }

    //enable multiport
    private string getMultiport() {

        string temp_multiport = "";

        if (checkbutton_multiport.Active) {
            temp_multiport = "--match multiport";
        }

        return temp_multiport;
    }


    //get mac string
    private string getMACstring() {

        string macstring = "";

        if (checkbutton_mac_not.Active) { 

            if (!entry_mac.Text.Equals(""))
            {
                macstring = "-m mac ! --mac-source " + entry_mac.Text;

            }

        }
        else
        {

            if (!entry_mac.Text.Equals(""))
            {
                macstring = "-m mac --mac-source " + entry_mac.Text;

            }
        }

        return macstring;

    }

    //get states NEW INVALID ESTABLISHED RELATED
    private string getStates() {
        string temp_states = "";


        if (checkbutton_NEW.Active || checkbutton_INVALID.Active || checkbutton_ESTABLISHED.Active || checkbutton_RELATED.Active) {
            temp_states = "-m conntrack --ctstate ";
            if (checkbutton_NEW.Active) { 
                temp_states += "NEW,";
            }
            if (checkbutton_INVALID.Active)
            {
                temp_states += "INVALID,";
            }
            if (checkbutton_ESTABLISHED.Active)
            {
                temp_states += "ESTABLISHED,";
            }
            if (checkbutton_RELATED.Active) {
                temp_states += "RELATED,";
            }

            //cutting the last coma
            temp_states = temp_states.Substring(0, temp_states.Length - 1);

        }

        return temp_states;
    
    }


    //al anyadir regla
    protected void OnButtonRulesClicked(object sender, EventArgs e)
    {


        //pillar strings
        string direction = comboboxentry_direction.ActiveText;
        string filter = comboboxentry_filter.ActiveText;
        string protocol = comboboxentry_protocol.ActiveText.ToLower();
        string sip = entry_sip.Text;
        string sport = entry_sport.Text;
        string dip = entry_dip.Text;
        string dport = entry_dport.Text;

        //string ip/port
        string temp_sip = getSourceIp(sip);
        string temp_dip = getDestinationIp(dip);
        string temp_sport = getSourcePort(sport);
        string temp_dport = getDestinationPort(dport);


        //string otras cosas
        string temp_multiport = getMultiport();
        string temp_states = getStates();
        string mac = getMACstring();

        //string interfaces
        string input_interface = getInputInterface();
        string output_interface = getOutputInterface();


            //add rules
            if (protocol.Equals("icmp"))
            {


                if (direction.Equals("INPUT"))
                {
                    rules.Add("sudo iptables -A " + direction + " " + temp_states + " -p " + protocol + " " + input_interface + " " + temp_multiport + " " + mac + " " + temp_sip + " -j " + filter);
                }
                else if (direction.Equals("OUTPUT"))
                {
                    rules.Add("sudo iptables -A " + direction + " " + temp_states + " -p " + protocol + " " + output_interface + " " + temp_multiport + " " + temp_dip + " -j " + filter);
                }
                else
                {
                    rules.Add("sudo iptables -A " + direction + " " + temp_states + " -p " + protocol + " " + input_interface + " " + output_interface + " " + temp_multiport + " " + mac + " " + temp_dip + " " + temp_sip + " -j " + filter);
                }

            }
            else
            {
                if (direction.Equals("INPUT"))
                {
                    rules.Add("sudo iptables -A " + direction + " " + temp_states + " -p " + protocol + " " + input_interface + " " + temp_multiport + " " + temp_sip + " " + mac + " " + temp_dport + " -j " + filter);
                }
                else if (direction.Equals("OUTPUT"))
                {
                    rules.Add("sudo iptables -A " + direction + " " + temp_states + " -p " + protocol + " " + output_interface + " " + temp_multiport + " " + temp_dip + " " + temp_sport + " -j " + filter);
                }
                else
                {
                    rules.Add("sudo iptables -A " + direction + " " + temp_states + " -p " + protocol + " " + input_interface + " " + output_interface + " " + temp_multiport + " " + mac + " " + temp_dip + " " + temp_sport + " " + temp_sip + " " + temp_dport + " -j " + filter);
                }
            }

            ShowMessage(this, "Alert Box", "Rule Added");


    }

    //al anyadir NAT
    protected void OnButtonNATClicked(object sender, EventArgs e)
    {

        NetworkInterface[] adaptadores = NetworkInterface.GetAllNetworkInterfaces();

        string private_interface = "";
        string public_interface = "";

        if (!comboboxentry_interfaces.ActiveText.Equals("none") && !comboboxentry_interface_output.ActiveText.Equals("none"))
        {

            foreach (NetworkInterface ni in adaptadores)
            {
                //pillar interface privada y ip
                if (ni.Name.Equals(comboboxentry_interfaces.ActiveText))
                {
                    private_interface = ni.Name;

                }

                //pillar interface publica y ip
                if (ni.Name.Equals(comboboxentry_interface_output.ActiveText))
                {
                    public_interface = ni.Name;

                }

            }



            rules.Add("sudo echo 1 > /proc/sys/net/ipv4/ip_forward ");
            rules.Add("sudo iptables -t nat -F");
            rules.Add("sudo iptables -t nat --delete-chain");
            rules.Add("sudo iptables --table nat --append POSTROUTING --out-interface " + public_interface + " -j MASQUERADE");
            rules.Add("sudo iptables --append FORWARD --in-interface " + private_interface + " -j ACCEPT");
            rules.Add("sudo echo 1 > /proc/sys/net/ipv4/ip_forward");

            ShowMessage(this, "Alert Box", "NAT rule added");
        } else {

            ShowMessage(this, "Alert Box", "Error: Select the two interfaces");
        
        }



    }

    //port forwarding
    protected void OnButtonPortForwardingClicked(object sender, EventArgs e)
    {
        if (comboboxentry_interfaces.ActiveText.Equals("none") || comboboxentry_protocol.ActiveText.Equals("ICMP") || entry_sport.Text.Equals("") || entry_dport.Text.Equals("") || entry_dip.Text.Equals("")) {
            ShowMessage(this, "Alert Box", "Error: select input interface, source port, destination port, destination IP and tcp or udp as a protocol");
        }
        else
        {

            rules.Add("sudo iptables -t nat -A PREROUTING -i " + comboboxentry_interfaces.ActiveText + " -p " + comboboxentry_protocol.ActiveText.ToLower() + " -m " + comboboxentry_protocol.ActiveText.ToLower() + " --dport " + entry_sport.Text + " -j DNAT --to " + entry_dip.Text + ":" + entry_dport.Text);
        }
    }
}


//iptables -t nat -A PREROUTING -i eth0 -p tcp -m tcp --dport 11000 -j DNAT --to zz.zz.zz.zz:22