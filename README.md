Arduino RGB LED GUI

This repository contains a Windows Forms application and accompanying Arduino script to control an RGB LED via a simple GUI. It's perfect for users who prefer software development over direct circuit design but still enjoy working with Arduino.
Prerequisites

Before running the project, ensure the following tools are installed:

    .NET SDK: Required to build and run the Windows Forms application.
        Download and install the .NET SDK from here.

    Arduino IDE: Required to flash the Arduino script to your board.
        Download and install the Arduino IDE from here.

    An Arduino board with an RGB LED circuit. Refer to the IMGS folder for the circuit diagram.

Setup
Arduino Script

    Open the Arduino IDE.
    Load the script from the /ArduinoRGBGUIScript directory.
    Verify the script by clicking the "Verify" button in the Arduino IDE.
    Flash the script to your Arduino board by clicking "Upload."

Windows Forms Application

    Clone the repository:

git clone https://github.com/ChavezJuanC/Arduino-RGB-LED-GUI.git
cd Arduino-RGB-LED-GUI/Arduino RGB LED GUI

Restore and build the application:

    dotnet restore
    dotnet build

Usage

    Start the Windows Forms application:

    dotnet run

    Use the GUI to adjust RGB values. The changes will be sent to the Arduino via the selected COM port.

Why This Project?

I received an Arduino for Christmas and, while I’m not a big hardware person, I enjoy combining software development with simple circuit designs. Instead of hardcoding RGB values or using the Serial Monitor, I created a GUI with Windows Forms to simplify the process.
What I Learned

    Communicating through COM ports with Arduino using C#'s System.IO.Ports library.
    Sending data to the correct COM port for dynamic control.
    Reusing this approach across different programming languages.

License

Feel free to use and adapt this project. Contributions are welcome!
