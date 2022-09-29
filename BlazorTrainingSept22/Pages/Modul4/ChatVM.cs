namespace BlazorTrainingSept22.Pages.Modul4
{
    public class ChatVM
    {
        public Action OnAdd;
        public List<NachrichtenModel> NachrichtenListe { get; set; } = new List<NachrichtenModel>();
        public void Add(string eingabe)
        {
            NachrichtenListe.Add(new NachrichtenModel() { Text = eingabe });
            OnAdd?.Invoke();
        }
    }
}
