using System;

namespace TicketPrint.Domain
{
    class Ticket
    {

        public static string Print(string descripcion, double price, string tipo, string userName)
        {
            string smsTicket = "";
            switch (tipo)
            {
                case "Deposit":
                    smsTicket = "------------------------------------------------------------------------------------" + Environment.NewLine;
                    smsTicket += $"Dear {userName} this is the ticket conforming you are Depositing a dog to us." + Environment.NewLine;
                    smsTicket += $"The dog its {descripcion}" + Environment.NewLine;
                    smsTicket += $"You must pay: {price} on the cash register" + Environment.NewLine;
                    smsTicket += "------------------------------------------------------------------------------------" + Environment.NewLine;
                    break;
                case "Adopt":
                    smsTicket = "------------------------------------------------------------------------------------" + Environment.NewLine;
                    smsTicket += $"Dear {userName} this is the ticket conforming you are Adopting a dog to us." + Environment.NewLine;
                    smsTicket += $"The dog its {descripcion}" + Environment.NewLine;
                    smsTicket += $"You must pay: {price} on the cash register" + Environment.NewLine;
                    smsTicket += "------------------------------------------------------------------------------------" + Environment.NewLine;
                    break;
                default:
                    break;
            }

            return smsTicket;
        }
    }
}
