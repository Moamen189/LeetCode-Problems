using System.Threading;
public class Foo {
    int count;

    public Foo() {
        count= 1;
    }

    public void First(Action printFirst) {
        SpinWait.SpinUntil(() => count == 1);
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        count++;
    }

    public void Second(Action printSecond) {
        SpinWait.SpinUntil(() => count == 2);
        
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
                count++;

    }

    public void Third(Action printThird) {
                SpinWait.SpinUntil(() => count == 3);

        // printThird() outputs "third". Do not change or remove this line.
        printThird();
                count++;

    }
}