#!/bin/bash

echo "[+] Testing packet managers" 

sudo apt update &>/dev/null && echo "[+] apt detected " && SELECTOR_PM="apt"
sudo dnf -h &>/dev/null && sudo yum -h &>/dev/null && echo "[+] dnf-yum detected " && SELECTOR_PM="dnf-yum"
sudo zypper &>/dev/null && echo "[+] zypper detected " && SELECTOR_PM="zypper"

echo "[+] Installing dependencies"
if [ "$SELECTOR_PM" = "apt" ]; then
	sudo apt update && sudo apt install mono-runtime gtk-sharp2 x11-apps -y	
elif [ "$SELECTOR_PM" = "dnf-yum" ]; then
	sudo dnf install mono-complete gtk-sharp2 -y
	sudo yum install xorg-x11-apps -y
elif [ "$SELECTOR_PM" = "zypper" ]; then
	sudo zypper -n in mono-complete gtk-sharp2 x11-tools
else
	echo "[+] Compatible packet manager not found"
	echo "[+] Please install mono-runtime gtk-sharp2 (and x11-apps for x11 forwarding)"
fi
echo "[+] Moving easytables to path"
sudo cp easytables.exe /bin/easytables
sudo chown $(logname 2>/dev/null || echo ${SUDO_USER:-${USER}}) /bin/easytables
sudo chmod 700 /bin/easytables
echo "[+] Done"
echo "[+] Testing"
easytables
if [ $? -ne 0 ]; then
	echo "[+] Error found, linking mono to easytables"
	if [ "$SHELL" = "/bin/bash" ]; then
		echo 'alias easytables="mono /bin/easytables"' >> /home/$(logname)/.bashrc
	elif [ "$SHELL" = "/bin/zsh" ]; then
		echo 'alias easytables="mono /bin/easytables"' >> /home/$(logname)/.zshrc
	fi
	echo "[+] Restart the shell and test easytables"
fi