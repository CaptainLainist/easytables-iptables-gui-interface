# Easytables (Beta, Under construction)

Easytables is an graphical interface for creating iptables bash files in an easy way

## Installation (with apt)

Download the release, unzip it and then execute the next code

```bash
sudo chmod u+x easytables.exe install-debian-based.sh
./install-debian-based.sh
easytables
```
## Installation (without apt)

Install mono-runtime and gtk-sharp2 with your packet manager
and then execute

```bash
sudo chmod u+x easytables.exe
sudo cp easytables.exe /bin/easytables
sudo chown user /bin/easytables
sudo chgrp user /bin/easytables
easytables
```
remember changing user by your local user
