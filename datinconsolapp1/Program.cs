using datinconsolapp1;

ShowMessage();
ICaller caller = new Jonior();
bool chooslevel = false;
string level = Console.ReadLine();
while (!chooslevel)
{
	switch (level)
	{
		case "jonior":
            chooslevel=true;
            caller = new Jonior();
            break;
        case "midlevel": chooslevel=true;
            caller = new Middlevele(); break;
		case "seniortazekar": chooslevel= true;
            caller = new Senior();
            break;
        default:
            ShowMessage();
            level = Console.ReadLine();
            break;
	}
}
caller.Call();

void ShowMessage() {
    Console.WriteLine("Levelet Ro Entekhab Kon");
    Console.WriteLine("jonior - midlevel - seniortazekar ");
}