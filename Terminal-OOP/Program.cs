
using Terminal_OOP;
bool Exit=false;
while (Exit==false)
{
    int menu = Terminal.GetInt($"1)Add Bus\n" +
        $"2)Add Trip\n" +
        $"3)show tripes\n" +
        $"4)book a ticket\n" +
        $"5)Buy a ticket\n" +
        $"6)Cancel the ticket\n" +
        $"7)show total\n" +
        $"0)EXIT");

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
                int exit = Terminal.GetInt("0)exit OR 1)continue");
                if (exit == 0)
                {
                    break;
                }
                else
                    Terminal.BookATicket();
                break;
            }
        case 5:
            {
                int exit = Terminal.GetInt("0)exit OR 1)continue");
                if (exit == 0)
                {
                    break;
                }
                else
                    Terminal.BuyATicket();
              
                break;
            }
        case 6:
            {
                int exit = Terminal.GetInt("0)exit OR 1)continue");
                if (exit == 0)
                {
                    break;
                }
                else
                {
                    Terminal.CancelTheTrip();
                }
                break;
            }
        case 7:
            {
                Terminal.showTotal();
               
                break;
            }
            case 0:
            {
                Exit = true;
                break;
            }

    }
}