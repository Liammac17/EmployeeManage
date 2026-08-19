namespace Client.ApplicationState
{
    public enum BannerItem
    {
        Employees,
        Vacations,
        Overtimes,
        Health,
        Sanctions,
        Departments
    }

    public enum BannerOperation
    {
        Add,
        Delete
    }
    public class BannerState
    {
        public event Action? Changed;

        public int Employees { get; private set; }
        public int Vacations { get; private set; }
        public int Overtimes { get; private set; }
        public int Health { get; private set; }
        public int Sanctions { get; private set; }
        public int Departments { get; private set; }

        public void SetCounts(int employees, int vacations, int overtimes, int health, int sanctions, int departments)
        {
            Employees = employees;
            Vacations = vacations;
            Overtimes = overtimes;
            Health = health;
            Sanctions = sanctions;
            Departments = departments;
            Changed?.Invoke();
        }

        public void ApplyChange(BannerItem item, BannerOperation operation)
        {
            var change = operation == BannerOperation.Add ? 1 : -1;

            switch (item)
            {
                case BannerItem.Employees:
                    Employees = Math.Max(0, Employees + change);
                    break;
                case BannerItem.Vacations:
                    Vacations = Math.Max(0, Vacations + change);
                    break;
                case BannerItem.Overtimes:
                    Overtimes = Math.Max(0, Overtimes + change);
                    break;
                case BannerItem.Health:
                    Health = Math.Max(0, Health + change);
                    break;
                case BannerItem.Sanctions:
                    Sanctions = Math.Max(0, Sanctions + change);
                    break;
                case BannerItem.Departments:
                    Departments = Math.Max(0, Departments + change);
                    break;
            }

            Changed?.Invoke();

        }
    }
}
