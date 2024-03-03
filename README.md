# Easytables

Easytables is an graphical interface for creating iptables bash files in an easy way

![alt text](https://raw.githubusercontent.com/CaptainLainist/easytables-iptables-gui-interface/main/easytables/bin/Screenshot_1.png)

## Compatible packet managers

 - apt
 - dnf and yum (needs both)
 - zypper

## if the error "[+] Error found, linking mono to easytables to fix it" is found
it will fix itself only on

 - bash
 - zsh

if you use a different shell please write 'mono /bin/easytables' to execute it or add an alias in your .whateverrc

## Tested on

 - linux mint
 - fedora (the text sometimes becomes invisible but works)
 - opensuse
 - kali
 - ubuntu server (needs x11 forwarding)

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


```bash
sudo chmod u+x easytables.exe
sudo cp easytables.exe /bin/easytables
sudo chown user /bin/easytables
easytables

#if there's some error about corrupt binary try this
mono /bin/easytables
```
remember changing user by your local user.

Also install x11-apps for enabling x11 forwarding
