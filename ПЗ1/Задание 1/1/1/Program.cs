class Program
{
    class basic
    {
        public void metod()
        {
            Console.WriteLine("Метод класса 'basic' выполнен");
        }
    }
    class naslednik : basic
    {
        public new void metod()
        {
            Console.WriteLine("Метод класса 'naslednik' выполнен");
        }
    }
    class naslednik_naslednika : naslednik
    {
        public new void metod()
        {
            Console.WriteLine("Метод класса 'naslednik_naslednika' выполнен");
        }
    }
    static void Main(string[] args)
    {

        // Пункт 1 Неявное преобразование
        Console.WriteLine("Пункт 1 Неявное преобразование");
        char ch = 'a';
        Console.WriteLine(ch);
        int i_1 = ch;
        Console.WriteLine(i_1);
        float f_1 = i_1;
        Console.WriteLine(f_1);
        double d_1 = f_1;
        Console.WriteLine(d_1);

        naslednik nas = new naslednik();
        basic bas = nas;

        // Пункт 2 Явное преобразование
        Console.WriteLine("Пункт 2 Явное преобразование");
        float a = 1.15f;
        Console.WriteLine(a);
        int b = (int)a;
        Console.WriteLine(b);
        char c = (char)b;
        Console.WriteLine(c);

        //basic bas_2 = new basic();
        //naslednik nas_2 = (naslednik)bas_2;

        // Пункт 3 Вызвать и обработать исключение преобразования типов;
        Console.WriteLine("Пункт 3 Вызвать и обработать исключение преобразования типов");
        try
        {
            dynamic dyn_3 = 1.3;
            float f_3 = dyn_3;
        }
        catch
        {
            Console.WriteLine("Преобразование невозможно");
        }
        // Пункт 4 Безопасное приведение ссылочных типов с помощью операторов as и is; 
        Console.WriteLine("Пункт 4 Безопасное приведение ссылочных типов с помощью оператора is");
        naslednik nas_4 = new naslednik();
        if (nas_4 is naslednik)
        {
            Console.WriteLine("Преобразованеи в 'nasledik' возможно");
        }
        if (nas_4 is basic)
        {
            Console.WriteLine("Преобразованеи в 'basic' возможно");
        }
        if (nas_4 is naslednik_naslednika)
        {
            Console.WriteLine("Преобразованеи в 'naslednik_naslednika' возможно");
        }


        Console.WriteLine("...с помощью оператора as");

        void TestForBasic(object o)
        {
            var m = o as basic;
            if (m != null)
            {
                m.metod();
            }
            else
            {
                Console.WriteLine("Преобразованеи в 'basic' не возможно");
            }
        }
        void TestForNaslednik_naslednika(object o)
        {
            var m = o as naslednik_naslednika;
            if (m != null)
            {
                m.metod();
            }
            else
            {
                Console.WriteLine("Преобразованеи в 'naslednik_naslednika' не возможно");
            }
        }

        TestForBasic(nas_4);
        TestForNaslednik_naslednika(nas_4);

        // Пункт 5 Пользовательское преобразование типов Implicit, Explicit;

    }
}

/* Таблица неявных преобразований
sbyte => short , int, long, float, double или decimal
byte => short, ushort, int, uint, long, float, double или decimal
short => int , long, float, double или decimal
ushort => int , uint, long, ulong, float, double или decimal
int => long , float, double или decimal
uint => long , ulong, float, double или decimal
long => float , double или decimal
char => ushort , int, uint, long, ulong, float, double или decimal
float => double
ulong => float , double или decimal
Объект - наследник => Объект базового класса
 */

/* Таблица явных преобразований
sbyte => byte , ushort, uint, ulong или char 
byte => Sbyte или char 
short => sbyte , byte, ushort, uint, ulong или char 
ushort => sbyte , byte, short или char
int => sbyte , byte, short, ushort, uint, ulong или char
uint => sbyte , byte, short, ushort, int или char 
long => sbyte , byte, short, ushort, int, uint, ulong или char 
ulong => sbyte , byte, short, ushort, int, uint, long или char 
char => sbyte , byte или short 
float => sbyte , byte, short, ushort, int, uint, long, ulong, char или decimal 
double => sbyte , byte, short, ushort, int, uint, long, ulong, char, float или decimal 
decimal => sbyte , byte, short, ushort, int, uint, long, ulong, char, float или double 
Объект базового класса => Объект - наследник
 */