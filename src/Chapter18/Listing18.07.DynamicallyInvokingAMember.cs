namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_07
{
    #region INCLUDE
    using System.ComponentModel;

    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public Person(string name)
        {
            Name = name;
        }
        private string _Name = string.Empty;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    PropertyChanged?.Invoke(
                        this,
                    #region HIGHLIGHT
                        new PropertyChangedEventArgs(
                            nameof(Name)));
                    #endregion HIGHLIGHT
                }
            }
        }
        // ...
    }
    #endregion INCLUDE
}