#!/bin/bash
echo --- INSTALLING DEPENDENCIES ---
USER=$(whoami)
if [ "$USER" = "root" ]; then
	echo --- RUN IT WITHOUT ROOT PRIVILEGES ---
else
	sudo apt update
	sudo apt install mono-runtime gtk-sharp2 -y
	echo --- MOVING EASYTABLES TO PATH ---
	sudo cp easytables.exe /bin/easytables
	sudo chown $USER /bin/easytables
	sudo chgrp $USER /bin/easytables
	echo --- DONE ---
fi