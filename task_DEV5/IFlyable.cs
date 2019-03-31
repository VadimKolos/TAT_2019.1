namespace task_DEV5
{
    interface IFlyable
    {
        int [] FlyTo(Point newPoint);
        string WhoAmI();
        double GetFlyTime(int [] coordinateArray);
    }
}
