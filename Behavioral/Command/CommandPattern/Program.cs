using CommandPattern._01_Approach;
using CommandPattern._02_Approach;
using ICommand = CommandPattern._01_Approach.ICommand;

Console.WriteLine("01_Approach Command Pattern ================");
Console.WriteLine(" ");

Invoker invoker = new();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));

Receiver receiver = new();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();

Console.WriteLine(" ");

Console.WriteLine("02_Approach Command Pattern ===============");
Console.WriteLine(" ");

Light livingRoomLight = new();

// Commands
CommandPattern._02_Approach.ICommand turnOnCommand = new TurnOnLightCommand(livingRoomLight);
CommandPattern._02_Approach.ICommand turnOffCommand = new TurnOffLightCommand(livingRoomLight);

// Invoker
RemoteControl remoteControl = new();
remoteControl.SetCommand(turnOnCommand);
remoteControl.PressButton(); // Turns on the light

// Undo the last command
remoteControl.PressUndo();

// Set a different command
remoteControl.SetCommand(turnOffCommand);
remoteControl.PressButton();

// Undo the last command
remoteControl.PressUndo();