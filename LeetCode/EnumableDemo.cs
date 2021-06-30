using System.Collections;

namespace LeetCode
{
    /// <summary>
    /// https://www.cnblogs.com/yangcaogui/archive/2011/12/04/2266589.html
    /// </summary>
    public class MyColors : ISolution  //: IEnumerable
    {
        string[] colors = { "Red", "Yellow", "Biue" };

        public IEnumerator GetEnumerator()
        {
            return new MyIEnumerator(colors);

            //这边就是我们要改动的地方，返回一个自己创建的类型，不是在返回数组的IEnumerator对象了，而是我们自己创建的枚举数对象→MyIEnumerator
        }

        public void Test()
        {
            foreach (var item in new MyColors())
            {

            }
        }
    }

    public class MyIEnumerator : IEnumerator
    {

        string[] colors;      
        int position = -1;    

        public MyIEnumerator(string[] colors)
        {
            this.colors = new string[colors.Length];

            for (int i = 0; i < this.colors.Length; i++)
            {
                this.colors[i] = colors[i];
            }
        }

        public object Current  //根据当前项获取相应的值
        {
            get
            {
                return colors[position];  //返回当前项的值，但是会做一个装箱的操作！
            }
        }

        public bool MoveNext()      //移动到下一项
        {
            if (position < colors.Length - 1)   //这就是设置默认值为-1的根据
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()       //重置当前项的值，恢复为默认值
        {
            this.position = -1;
        }
    }
}
