
using Terminal_OOP;

while (true)
{
    int menu = Terminal.GetInt($"1)Add Bus\n" +
        $"2)Add Trip\n" +
        $"3)show tripes\n" +
        $"4)book a ticket\n" +
        $"5)Buy a ticket\n" +
        $"9)show total");

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
            case 4:
            {
                Terminal.BookATicket();
                break;
            }
        case 5:
            {
                Terminal.BuyATicket();
                break;
            }
        case 9:
            {

                Terminal.showTotal();
                break;
            }
    }
}