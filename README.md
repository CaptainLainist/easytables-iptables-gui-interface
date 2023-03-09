# Easytables (Beta, Under construction)

Easytables is an graphical interface for creating iptables bash files in an easy way

![alt text](https://raw.githubusercontent.com/CaptainLainist/easytables-iptables-gui-interface/main/easytables/bin/Screenshot_1.png)

## Compatible packet managers

 - apt
 - dnf and yum (needs both)
 - zypper
## Tested on

 - linux mint
 - fedora
 - opensuse

## Installation (with compatible packet managers)

Download the release, unzip it and then execute the next code

```bash
sudo chmod u+x install-easytables.sh
./install-easytables.sh
easytables
```
## Installation (without compatible packet managers)

Install mono-runtime and gtk-sharp2 with your packet manager
and then execute
also install x11-apps for enabling x11 forwarding

```bash
sudo chmod u+x easytables.exe
sudo cp easytables.exe /bin/easytables
sudo chown user /bin/easytables
easytables
```
remember changing user by your local user
