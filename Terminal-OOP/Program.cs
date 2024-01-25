
using Terminal_OOP;

while (true)
{
    int menu = Terminal.GetInt($"1)Add Bus\n" +
        $"2)Add Trip\n" +
        $"3)show tripes");

    switch (menu)
    {
        case 1:
            {

                string name = Terminal.GetString("Enter Bus Name");
                int type = Terminal.GetInt("1)Normal--2)VIP");
                Terminal.Addbus(name, type);
                break;
            }
        case 2:
            {
                int type = Terminal.GetInt("1)Normal--2)VIP");
                Terminal.AddTrip(type);
                break;
            }
        case 3:
            {
                Terminal.ShowTrip();

                break;
            }
    }
}