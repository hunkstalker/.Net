using ProsperDaily.MAUI.MVVM.Models;

namespace ProsperDaily.MAUI.MVVM.ViewModels
{
    public class TransactionsViewModel
    {
        public Transaction Transaction { get; set; } = new Transaction
        {
            // TODO: De este modo la fecha no coge el valor del control DatePicker, obviamente...
            OperationDate = DateTime.Now,
        };

        public string SaveTransaction()
        {
            App.TransactionsRepo.SaveItem(Transaction);
            return App.TransactionsRepo.StatusMessage;
        }
    }
}
