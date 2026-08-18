using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Print("a");
        Print(6);
        var num = new Any<int>();
        num.Add(1);
        num.Add(2);
        num.Add(3);
        num.Add(4);
        
        Console.WriteLine( $"Length: {num.Count}");
        Console.WriteLine( $"Empty: {num.IsEmpty}");
        num.RemoveAt(1);
        num.DisplayList();
        var str = new Any<string>();
        str.Add("a");
        str.Add("b");
        str.Add("c");
        str.Add("d");
        str.DisplayList();
        var arr = new ArrayList();//type safe
        arr.Add("a");
        Console.WriteLine( arr);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
    static void Print <T>(T obj)
    {
        Console.WriteLine($"Data {obj}");
    }
    //where T :constraint ,constraint2 ,
    // where T: struct 
    // where T: class 
    // where T: class? 
    // where T: notnull 
    // where T: default 
    // where T: numanaged
    class Any<T> //where T :class ,new()
    {
        private T[] _item;
        public void Add(T item)
        {
            if(_item is null)
            {
                _item = new T[] { item };
            }
            else
            {
                var length=_item.Length;
                var dest = new T[length + 1];
                for (int i = 0; i < length; i++)
                {
                    dest[i]=_item[i];
                }
                dest[dest.Length-1] = item;

                _item = dest;

            }
        }
        public void RemoveAt(int position)
        {
            if (position < 0 || position > _item.Length - 1)
            {
                return;
            }
            var index = 0;
            var dest = new T[_item.Length - 1];
            for (int i = 0; i < _item.Length; i++)
            {
                if (position == i)
                    continue;
                dest[index++]=_item[i];
            }
            _item = dest;
        }

        public bool IsEmpty=>_item is null || _item.Length== 0;
        public int Count => _item is null ? 0 : _item.Length;
        public void DisplayList()
        {
            Console.Write("[");
            for (int i = 0; i < _item.Length; i++)
            {
                Console.Write(_item[i]);
                if (i < _item.Length - 1) {
                    Console.Write(", ");
                }

            }
            Console.WriteLine("]");
        }
    }
}
