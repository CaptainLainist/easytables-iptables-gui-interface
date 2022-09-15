#!/bin/bash
echo --- INSTALLING DEPENDENCIES ---
sudo apt update
sudo apt install mono-runtime gtk-sharp2 -y
echo --- MOVING EASYTABLES TO PATH ---
sudo cp easytables.exe /bin/easytables
echo --- DONE ---