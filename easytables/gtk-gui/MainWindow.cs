
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label titlelbl;

	private global::Gtk.Label label_input;

	private global::Gtk.Label label_output;

	private global::Gtk.Label label_forward;

	private global::Gtk.Label label_gen;

	private global::Gtk.ComboBoxEntry comboboxentry_input;

	private global::Gtk.ComboBoxEntry comboboxentry_output;

	private global::Gtk.ComboBoxEntry comboboxentry_forward;

	private global::Gtk.Button genbutton;

	private global::Gtk.CheckButton checkbutton_loopback;

	private global::Gtk.ComboBoxEntry comboboxentry_direction;

	private global::Gtk.ComboBoxEntry comboboxentry_filter;

	private global::Gtk.Label label2;

	private global::Gtk.Label title_rules;

	private global::Gtk.Label label3;

	private global::Gtk.Label LBL_PROTOCOL;

	private global::Gtk.ComboBoxEntry comboboxentry_protocol;

	private global::Gtk.CheckButton checkbutton_x11;

	private global::Gtk.Button button_rules;

	private global::Gtk.Entry entry_sip;

	private global::Gtk.Entry entry_dport;

	private global::Gtk.Entry entry_sport;

	private global::Gtk.Entry entry_dip;

	private global::Gtk.CheckButton checkbutton_multiport;

	private global::Gtk.CheckButton checkbutton_NEW;

	private global::Gtk.CheckButton checkbutton_ESTABLISHED;

	private global::Gtk.CheckButton checkbutton_RELATED;

	private global::Gtk.CheckButton checkbutton_INVALID;

	private global::Gtk.Label label_STATES;

	private global::Gtk.ComboBoxEntry comboboxentry_interfaces;

	private global::Gtk.ComboBoxEntry comboboxentry_interface_output;

	private global::Gtk.Label label1;

	private global::Gtk.Label label4;

	private global::Gtk.Button button_NAT;

	private global::Gtk.Button button_port_forwarding;

	private global::Gtk.Label label5;

	private global::Gtk.Label label6;

	private global::Gtk.Label label7;

	private global::Gtk.Label label8;

	private global::Gtk.CheckButton checkbutton_mac_not;

	private global::Gtk.Entry entry_mac;

	private global::Gtk.Label label9;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview_rules;

	private global::Gtk.Label label10;

	private global::Gtk.Button button_remove_rules;

	private global::Gtk.Button button_remove_last;

	private global::Gtk.Button button_remove_rule_number;

	private global::Gtk.ComboBoxEntry comboboxentry_nums;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.titlelbl = new global::Gtk.Label();
		this.titlelbl.Name = "titlelbl";
		this.titlelbl.LabelProp = "easyTables";
		this.fixed1.Add(this.titlelbl);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.titlelbl]));
		w1.X = 25;
		w1.Y = 16;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label_input = new global::Gtk.Label();
		this.label_input.Name = "label_input";
		this.label_input.LabelProp = global::Mono.Unix.Catalog.GetString("INPUT: ");
		this.fixed1.Add(this.label_input);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label_input]));
		w2.X = 533;
		w2.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label_output = new global::Gtk.Label();
		this.label_output.Name = "label_output";
		this.label_output.LabelProp = global::Mono.Unix.Catalog.GetString("OUTPUT: ");
		this.fixed1.Add(this.label_output);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label_output]));
		w3.X = 533;
		w3.Y = 80;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label_forward = new global::Gtk.Label();
		this.label_forward.Name = "label_forward";
		this.label_forward.LabelProp = global::Mono.Unix.Catalog.GetString("FORWARD: ");
		this.fixed1.Add(this.label_forward);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label_forward]));
		w4.X = 533;
		w4.Y = 110;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label_gen = new global::Gtk.Label();
		this.label_gen.Name = "label_gen";
		this.label_gen.LabelProp = global::Mono.Unix.Catalog.GetString("GENERAL RULES");
		this.fixed1.Add(this.label_gen);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label_gen]));
		w5.X = 514;
		w5.Y = 23;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_input = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_input.AppendText(global::Mono.Unix.Catalog.GetString("ACCEPT"));
		this.comboboxentry_input.AppendText(global::Mono.Unix.Catalog.GetString("DROP"));
		this.comboboxentry_input.AppendText(global::Mono.Unix.Catalog.GetString("REJECT"));
		this.comboboxentry_input.Name = "comboboxentry_input";
		this.comboboxentry_input.Active = 0;
		this.fixed1.Add(this.comboboxentry_input);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_input]));
		w6.X = 622;
		w6.Y = 45;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_output = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_output.AppendText(global::Mono.Unix.Catalog.GetString("ACCEPT"));
		this.comboboxentry_output.AppendText(global::Mono.Unix.Catalog.GetString("DROP"));
		this.comboboxentry_output.AppendText(global::Mono.Unix.Catalog.GetString("REJECT"));
		this.comboboxentry_output.Name = "comboboxentry_output";
		this.comboboxentry_output.Active = 0;
		this.fixed1.Add(this.comboboxentry_output);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_output]));
		w7.X = 622;
		w7.Y = 77;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_forward = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_forward.AppendText(global::Mono.Unix.Catalog.GetString("ACCEPT"));
		this.comboboxentry_forward.AppendText(global::Mono.Unix.Catalog.GetString("DROP"));
		this.comboboxentry_forward.AppendText(global::Mono.Unix.Catalog.GetString("REJECT"));
		this.comboboxentry_forward.Name = "comboboxentry_forward";
		this.comboboxentry_forward.Active = 0;
		this.fixed1.Add(this.comboboxentry_forward);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_forward]));
		w8.X = 622;
		w8.Y = 108;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.genbutton = new global::Gtk.Button();
		this.genbutton.CanFocus = true;
		this.genbutton.Name = "genbutton";
		this.genbutton.UseUnderline = true;
		this.genbutton.Label = global::Mono.Unix.Catalog.GetString("Generate bash file");
		this.fixed1.Add(this.genbutton);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.genbutton]));
		w9.X = 631;
		w9.Y = 577;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton_loopback = new global::Gtk.CheckButton();
		this.checkbutton_loopback.CanFocus = true;
		this.checkbutton_loopback.Name = "checkbutton_loopback";
		this.checkbutton_loopback.Label = global::Mono.Unix.Catalog.GetString("loopback");
		this.checkbutton_loopback.Active = true;
		this.checkbutton_loopback.DrawIndicator = true;
		this.checkbutton_loopback.UseUnderline = true;
		this.fixed1.Add(this.checkbutton_loopback);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton_loopback]));
		w10.X = 542;
		w10.Y = 154;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_direction = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_direction.AppendText(global::Mono.Unix.Catalog.GetString("INPUT"));
		this.comboboxentry_direction.AppendText(global::Mono.Unix.Catalog.GetString("OUTPUT"));
		this.comboboxentry_direction.AppendText(global::Mono.Unix.Catalog.GetString("FORWARD"));
		this.comboboxentry_direction.Name = "comboboxentry_direction";
		this.comboboxentry_direction.Active = 0;
		this.fixed1.Add(this.comboboxentry_direction);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_direction]));
		w11.X = 43;
		w11.Y = 187;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_filter = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_filter.AppendText(global::Mono.Unix.Catalog.GetString("ACCEPT"));
		this.comboboxentry_filter.AppendText(global::Mono.Unix.Catalog.GetString("DROP"));
		this.comboboxentry_filter.AppendText(global::Mono.Unix.Catalog.GetString("REJECT"));
		this.comboboxentry_filter.Name = "comboboxentry_filter";
		this.comboboxentry_filter.Active = 0;
		this.fixed1.Add(this.comboboxentry_filter);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_filter]));
		w12.X = 43;
		w12.Y = 241;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("DIRECTION");
		this.fixed1.Add(this.label2);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
		w13.X = 52;
		w13.Y = 168;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.title_rules = new global::Gtk.Label();
		this.title_rules.Name = "title_rules";
		this.title_rules.LabelProp = global::Mono.Unix.Catalog.GetString("RULES");
		this.fixed1.Add(this.title_rules);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.title_rules]));
		w14.X = 51;
		w14.Y = 127;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("FILTER");
		this.fixed1.Add(this.label3);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
		w15.X = 52;
		w15.Y = 223;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.LBL_PROTOCOL = new global::Gtk.Label();
		this.LBL_PROTOCOL.Name = "LBL_PROTOCOL";
		this.LBL_PROTOCOL.LabelProp = global::Mono.Unix.Catalog.GetString("PROTOCOL");
		this.fixed1.Add(this.LBL_PROTOCOL);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.LBL_PROTOCOL]));
		w16.X = 52;
		w16.Y = 280;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_protocol = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_protocol.AppendText(global::Mono.Unix.Catalog.GetString("TCP"));
		this.comboboxentry_protocol.AppendText(global::Mono.Unix.Catalog.GetString("UDP"));
		this.comboboxentry_protocol.AppendText(global::Mono.Unix.Catalog.GetString("ICMP"));
		this.comboboxentry_protocol.Name = "comboboxentry_protocol";
		this.comboboxentry_protocol.Active = 0;
		this.fixed1.Add(this.comboboxentry_protocol);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_protocol]));
		w17.X = 43;
		w17.Y = 297;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton_x11 = new global::Gtk.CheckButton();
		this.checkbutton_x11.CanFocus = true;
		this.checkbutton_x11.Name = "checkbutton_x11";
		this.checkbutton_x11.Label = global::Mono.Unix.Catalog.GetString("Allow X11");
		this.checkbutton_x11.DrawIndicator = true;
		this.checkbutton_x11.UseUnderline = true;
		this.fixed1.Add(this.checkbutton_x11);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton_x11]));
		w18.X = 542;
		w18.Y = 187;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button_rules = new global::Gtk.Button();
		this.button_rules.CanFocus = true;
		this.button_rules.Name = "button_rules";
		this.button_rules.UseUnderline = true;
		this.button_rules.Label = global::Mono.Unix.Catalog.GetString("Add rule");
		this.fixed1.Add(this.button_rules);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button_rules]));
		w19.X = 543;
		w19.Y = 577;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry_sip = new global::Gtk.Entry();
		this.entry_sip.CanFocus = true;
		this.entry_sip.Name = "entry_sip";
		this.entry_sip.IsEditable = true;
		this.entry_sip.InvisibleChar = '•';
		this.fixed1.Add(this.entry_sip);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry_sip]));
		w20.X = 469;
		w20.Y = 263;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry_dport = new global::Gtk.Entry();
		this.entry_dport.CanFocus = true;
		this.entry_dport.Name = "entry_dport";
		this.entry_dport.IsEditable = true;
		this.entry_dport.InvisibleChar = '•';
		this.fixed1.Add(this.entry_dport);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry_dport]));
		w21.X = 277;
		w21.Y = 263;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry_sport = new global::Gtk.Entry();
		this.entry_sport.CanFocus = true;
		this.entry_sport.Name = "entry_sport";
		this.entry_sport.IsEditable = true;
		this.entry_sport.InvisibleChar = '•';
		this.fixed1.Add(this.entry_sport);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry_sport]));
		w22.X = 277;
		w22.Y = 325;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry_dip = new global::Gtk.Entry();
		this.entry_dip.CanFocus = true;
		this.entry_dip.Name = "entry_dip";
		this.entry_dip.IsEditable = true;
		this.entry_dip.InvisibleChar = '•';
		this.fixed1.Add(this.entry_dip);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry_dip]));
		w23.X = 469;
		w23.Y = 328;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton_multiport = new global::Gtk.CheckButton();
		this.checkbutton_multiport.CanFocus = true;
		this.checkbutton_multiport.Name = "checkbutton_multiport";
		this.checkbutton_multiport.Label = global::Mono.Unix.Catalog.GetString("multiport");
		this.checkbutton_multiport.DrawIndicator = true;
		this.checkbutton_multiport.UseUnderline = true;
		this.fixed1.Add(this.checkbutton_multiport);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton_multiport]));
		w24.X = 293;
		w24.Y = 196;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton_NEW = new global::Gtk.CheckButton();
		this.checkbutton_NEW.CanFocus = true;
		this.checkbutton_NEW.Name = "checkbutton_NEW";
		this.checkbutton_NEW.Label = global::Mono.Unix.Catalog.GetString("NEW");
		this.checkbutton_NEW.DrawIndicator = true;
		this.checkbutton_NEW.UseUnderline = true;
		this.fixed1.Add(this.checkbutton_NEW);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton_NEW]));
		w25.X = 37;
		w25.Y = 373;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton_ESTABLISHED = new global::Gtk.CheckButton();
		this.checkbutton_ESTABLISHED.CanFocus = true;
		this.checkbutton_ESTABLISHED.Name = "checkbutton_ESTABLISHED";
		this.checkbutton_ESTABLISHED.Label = global::Mono.Unix.Catalog.GetString("ESTABLISHED");
		this.checkbutton_ESTABLISHED.DrawIndicator = true;
		this.checkbutton_ESTABLISHED.UseUnderline = true;
		this.fixed1.Add(this.checkbutton_ESTABLISHED);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton_ESTABLISHED]));
		w26.X = 37;
		w26.Y = 394;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton_RELATED = new global::Gtk.CheckButton();
		this.checkbutton_RELATED.CanFocus = true;
		this.checkbutton_RELATED.Name = "checkbutton_RELATED";
		this.checkbutton_RELATED.Label = global::Mono.Unix.Catalog.GetString("RELATED");
		this.checkbutton_RELATED.DrawIndicator = true;
		this.checkbutton_RELATED.UseUnderline = true;
		this.fixed1.Add(this.checkbutton_RELATED);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton_RELATED]));
		w27.X = 37;
		w27.Y = 415;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton_INVALID = new global::Gtk.CheckButton();
		this.checkbutton_INVALID.CanFocus = true;
		this.checkbutton_INVALID.Name = "checkbutton_INVALID";
		this.checkbutton_INVALID.Label = global::Mono.Unix.Catalog.GetString("INVALID");
		this.checkbutton_INVALID.DrawIndicator = true;
		this.checkbutton_INVALID.UseUnderline = true;
		this.fixed1.Add(this.checkbutton_INVALID);
		global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton_INVALID]));
		w28.X = 37;
		w28.Y = 434;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label_STATES = new global::Gtk.Label();
		this.label_STATES.Name = "label_STATES";
		this.label_STATES.LabelProp = global::Mono.Unix.Catalog.GetString("STATES");
		this.fixed1.Add(this.label_STATES);
		global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label_STATES]));
		w29.X = 38;
		w29.Y = 351;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_interfaces = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_interfaces.AppendText(global::Mono.Unix.Catalog.GetString("none"));
		this.comboboxentry_interfaces.Name = "comboboxentry_interfaces";
		this.comboboxentry_interfaces.Active = 0;
		this.fixed1.Add(this.comboboxentry_interfaces);
		global::Gtk.Fixed.FixedChild w30 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_interfaces]));
		w30.X = 29;
		w30.Y = 509;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_interface_output = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_interface_output.AppendText(global::Mono.Unix.Catalog.GetString("none"));
		this.comboboxentry_interface_output.Name = "comboboxentry_interface_output";
		this.comboboxentry_interface_output.Active = 0;
		this.fixed1.Add(this.comboboxentry_interface_output);
		global::Gtk.Fixed.FixedChild w31 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_interface_output]));
		w31.X = 271;
		w31.Y = 509;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("INPUT/PRIVATE INTERFACE");
		this.fixed1.Add(this.label1);
		global::Gtk.Fixed.FixedChild w32 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
		w32.X = 40;
		w32.Y = 478;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("PUBLIC/OUTPUT INTERFACE");
		this.fixed1.Add(this.label4);
		global::Gtk.Fixed.FixedChild w33 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label4]));
		w33.X = 282;
		w33.Y = 478;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button_NAT = new global::Gtk.Button();
		this.button_NAT.CanFocus = true;
		this.button_NAT.Name = "button_NAT";
		this.button_NAT.UseUnderline = true;
		this.button_NAT.Label = global::Mono.Unix.Catalog.GetString("Add NAT rule");
		this.fixed1.Add(this.button_NAT);
		global::Gtk.Fixed.FixedChild w34 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button_NAT]));
		w34.X = 61;
		w34.Y = 574;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button_port_forwarding = new global::Gtk.Button();
		this.button_port_forwarding.CanFocus = true;
		this.button_port_forwarding.Name = "button_port_forwarding";
		this.button_port_forwarding.UseUnderline = true;
		this.button_port_forwarding.Label = global::Mono.Unix.Catalog.GetString("Add port forwarding rule");
		this.fixed1.Add(this.button_port_forwarding);
		global::Gtk.Fixed.FixedChild w35 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button_port_forwarding]));
		w35.X = 467;
		w35.Y = 377;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("destination port");
		this.fixed1.Add(this.label5);
		global::Gtk.Fixed.FixedChild w36 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label5]));
		w36.X = 285;
		w36.Y = 241;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("source port");
		this.fixed1.Add(this.label6);
		global::Gtk.Fixed.FixedChild w37 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label6]));
		w37.X = 285;
		w37.Y = 300;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("source ip");
		this.fixed1.Add(this.label7);
		global::Gtk.Fixed.FixedChild w38 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label7]));
		w38.X = 481;
		w38.Y = 241;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label8 = new global::Gtk.Label();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("destination ip");
		this.fixed1.Add(this.label8);
		global::Gtk.Fixed.FixedChild w39 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label8]));
		w39.X = 481;
		w39.Y = 300;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton_mac_not = new global::Gtk.CheckButton();
		this.checkbutton_mac_not.CanFocus = true;
		this.checkbutton_mac_not.Name = "checkbutton_mac_not";
		this.checkbutton_mac_not.Label = global::Mono.Unix.Catalog.GetString("negate");
		this.checkbutton_mac_not.DrawIndicator = true;
		this.checkbutton_mac_not.UseUnderline = true;
		this.fixed1.Add(this.checkbutton_mac_not);
		global::Gtk.Fixed.FixedChild w40 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton_mac_not]));
		w40.X = 672;
		w40.Y = 265;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry_mac = new global::Gtk.Entry();
		this.entry_mac.CanFocus = true;
		this.entry_mac.Name = "entry_mac";
		this.entry_mac.IsEditable = true;
		this.entry_mac.InvisibleChar = '•';
		this.fixed1.Add(this.entry_mac);
		global::Gtk.Fixed.FixedChild w41 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry_mac]));
		w41.X = 674;
		w41.Y = 296;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("MAC SOURCE");
		this.fixed1.Add(this.label9);
		global::Gtk.Fixed.FixedChild w42 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label9]));
		w42.X = 685;
		w42.Y = 240;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.WidthRequest = 250;
		this.GtkScrolledWindow.HeightRequest = 200;
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview_rules = new global::Gtk.TextView();
		this.textview_rules.CanFocus = true;
		this.textview_rules.Name = "textview_rules";
		this.textview_rules.Editable = false;
		this.GtkScrolledWindow.Add(this.textview_rules);
		this.fixed1.Add(this.GtkScrolledWindow);
		global::Gtk.Fixed.FixedChild w44 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
		w44.X = 926;
		w44.Y = 228;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label10 = new global::Gtk.Label();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("VIEW RULES");
		this.fixed1.Add(this.label10);
		global::Gtk.Fixed.FixedChild w45 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label10]));
		w45.X = 927;
		w45.Y = 185;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button_remove_rules = new global::Gtk.Button();
		this.button_remove_rules.CanFocus = true;
		this.button_remove_rules.Name = "button_remove_rules";
		this.button_remove_rules.UseUnderline = true;
		this.button_remove_rules.Label = global::Mono.Unix.Catalog.GetString("Remove rules");
		this.fixed1.Add(this.button_remove_rules);
		global::Gtk.Fixed.FixedChild w46 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button_remove_rules]));
		w46.X = 430;
		w46.Y = 577;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button_remove_last = new global::Gtk.Button();
		this.button_remove_last.CanFocus = true;
		this.button_remove_last.Name = "button_remove_last";
		this.button_remove_last.UseUnderline = true;
		this.button_remove_last.Label = global::Mono.Unix.Catalog.GetString("Remove Last Rule");
		this.fixed1.Add(this.button_remove_last);
		global::Gtk.Fixed.FixedChild w47 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button_remove_last]));
		w47.X = 930;
		w47.Y = 442;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button_remove_rule_number = new global::Gtk.Button();
		this.button_remove_rule_number.CanFocus = true;
		this.button_remove_rule_number.Name = "button_remove_rule_number";
		this.button_remove_rule_number.UseUnderline = true;
		this.button_remove_rule_number.Label = global::Mono.Unix.Catalog.GetString("Remove Rule Number: ");
		this.fixed1.Add(this.button_remove_rule_number);
		global::Gtk.Fixed.FixedChild w48 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button_remove_rule_number]));
		w48.X = 930;
		w48.Y = 481;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry_nums = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry_nums.Name = "comboboxentry_nums";
		this.fixed1.Add(this.comboboxentry_nums);
		global::Gtk.Fixed.FixedChild w49 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxentry_nums]));
		w49.X = 1089;
		w49.Y = 481;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1296;
		this.DefaultHeight = 1987;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.genbutton.Clicked += new global::System.EventHandler(this.OnGenbuttonClicked);
		this.button_rules.Clicked += new global::System.EventHandler(this.OnButtonRulesClicked);
		this.button_NAT.Clicked += new global::System.EventHandler(this.OnButtonNATClicked);
		this.button_port_forwarding.Clicked += new global::System.EventHandler(this.OnButtonPortForwardingClicked);
		this.button_remove_rules.Clicked += new global::System.EventHandler(this.RemoveAllRulesBtn);
		this.button_remove_last.Clicked += new global::System.EventHandler(this.RemoveLastRuleBtn);
		this.button_remove_rule_number.Clicked += new global::System.EventHandler(this.RemoveRuleNUmberBtn);
	}
}
