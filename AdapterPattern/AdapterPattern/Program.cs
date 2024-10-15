namespace AdapterPattern
{

    // Клас TwoPinPlug представляє електричний вхід з двома контактами
    class TwoPinPlug
    {
        public void Connect() // Метод для підключення
        {
            Console.WriteLine("Two pins connected to the socket."); // Два контакти підключено до розетки.
        }
    }

    // Клас ThreePinPlug представляє електричний вхід з трьома контактами
    class ThreePinPlug
    {
        public void Connect() // Метод для підключення
        {
            Console.WriteLine("Three pins connected to the socket."); // Три контакти підключено до розетки.
        }
    }

    // Адаптер для трьохконтактних розеток
    class ThreePinToTwoPinAdapter : TwoPinPlug
    {
        private ThreePinPlug threePinPlug; // Внутрішній триконтактний вхід

        // Конструктор адаптера, який приймає об'єкт ThreePinPlug
        public ThreePinToTwoPinAdapter(ThreePinPlug threePinPlug)
        {
            this.threePinPlug = threePinPlug; // Зберігаємо об'єкт ThreePinPlug
        }

        // Переопределення методу Connect
        public new void Connect()
        {
            threePinPlug.Connect(); // Викликаємо метод підключення трьохконтактного входу
            Console.WriteLine("Adapted to two pins."); // Адаптовано до двох контактів.
        }
    }

    // Клас Program, що демонструє використання адаптера
    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єктів
            TwoPinPlug twoPinPlug = new TwoPinPlug(); // Створюємо об'єкт двоконтактного входу
            ThreePinPlug threePinPlug = new ThreePinPlug(); // Створюємо об'єкт трьохконтактного входу

            // Підключення двоконтактного входу
            twoPinPlug.Connect(); // Виклик методу підключення для двоконтактного входу

            // Використання адаптера для трьохконтактних розеток
            ThreePinToTwoPinAdapter adapter = new ThreePinToTwoPinAdapter(threePinPlug); // Створюємо адаптер для трьохконтактного входу
            adapter.Connect(); // Виклик методу підключення через адаптер
        }
    }
}
