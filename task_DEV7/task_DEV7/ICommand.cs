namespace task_DEV7
{
    /// <summary>
    /// Determines the function of counting.
    /// </summary>
    interface ICommand
    {
        string Execute(Catalog carList);
    }
}
