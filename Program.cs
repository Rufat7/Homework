#region task1
int number1 = 5;
int number2 = 10;
swap(ref number1, ref number2);

console.writeline(number1);
console.writeline(number2);


void swap<t>(ref t num1, ref t num2)
{
    t tmp = num1;
    num1 = num2;
    num2 = tmp;
}

#endregion

#region task2

intcompare intcompare = new intcompare();
priorityqueue<int> priorityqueue = new priorityqueue<int>(intcompare);

priorityqueue.enqueue(50);
priorityqueue.enqueue(3);
priorityqueue.enqueue(390);
priorityqueue.enqueue(39);


while (priorityqueue.count > 0)
{
    console.writeline(priorityqueue.dequeue());
}



class priorityqueue<t>
{
    private list<t> data;
    private icomparer<t> _comparer;


    public priorityqueue(icomparer<t> comparer)
    {
        data = new list<t>();
        _comparer = comparer;
    }

    public void enqueue(t item)
    {
        data.add(item);
        int childindex = data.count - 1;

        for (int i = 0; i < data.count(); i++)
        {
            int parentindex = (childindex - 1) / 2;
            if (_comparer.compare(data[childindex], data[parentindex]) >= 0)
                break;
            swap(childindex, parentindex);
            childindex = parentindex;
        }
    }

    public t dequeue()
    {
        int lastindex = data.count - 1;
        t frontitem = data[0];
        data[0] = data[lastindex];
        data.removeat(lastindex);

        lastindex--;
        int parentindex = 0;

        while (true)
        {
            int leftchildindex = parentindex * 2 + 1;
            if (leftchildindex > lastindex)
                break;

            int rightchildindex = leftchildindex + 1;
            if (rightchildindex <= lastindex && _comparer.compare(data[leftchildindex], data[rightchildindex]) > 0)
                leftchildindex = rightchildindex;

            if (_comparer.compare(data[parentindex], data[leftchildindex]) <= 0)
                break;

            swap(parentindex, leftchildindex);
            parentindex = leftchildindex;
        }
        return frontitem;
    }

    public int count
    {
        get { return data.count; }
    }

    private void swap(int index1, int index2)
    {
        t temp = data[index1];
        data[index1] = data[index2];
        data[index2] = temp;
    }
}


class intcompare : icomparer<int>
{
    public int compare(int x, int y)
    {
        if (x < y)
            return -1;
        if (x > y)
            return 1;
        return 0;
    }


}

#endregion

#region task3

doublelinkedlist<int> doublelinkedlist = new doublelinkedlist<int>();
doublelinkedlist.add(10);
doublelinkedlist.add(11);
doublelinkedlist.add(12);
doublelinkedlist.add(13);
doublelinkedlist.print();
doublelinkedlist.remove(12);
doublelinkedlist.print();
console.writeline(doublelinkedlist.size());
doublelinkedlist.addfirst(1);
doublelinkedlist.print();


class node<t>
{
    public t data;
    public node<t> prev;
    public node<t> next;

    public node(t data)
    {
        data = data;
        prev = null;
        next = null;
    }
}

class doublelinkedlist<t>
{
    private node<t> head;
    private node<t> tail;
    private int _size;


    public void add(t data)
    {
        node<t> newnode = new node<t>(data);
        if (head == null)
        {
            head = newnode;
            tail = newnode;
        }
        else
        {
            tail.next = newnode;
            newnode.prev = tail;
        }

        tail = newnode;
        _size++;
    }

    public void remove(t data)
    {
        node<t> current = head;
        node<t> previous = null;

        while (current != null)
        {
            if (current.data.equals(data))
            {
                break;
            }

            current = current.next;
        }

        if (current != null)
        {
            if (current.next != null)
            {
                current.next.prev = current.prev;
            }
            else
            {
                tail = current.prev;
            }

            if (current.prev != null)
            {
                current.prev.next = current.next;
            }
            else
            {
                head = current.next;
            }

            _size--;
        }


    }


    public int size() => _size;
    public void print()
    {
        node<t> current = head;
        while (current != null)
        {
            console.writeline(current.data);
            current = current.next;
        }
    }

    public void clear()
    {
        head = null;
        tail = null;
        _size = 0;
    }

    public bool contains(t data)
    {
        node<t> current = head;
        while (current != null)
        {
            if (current.data.equals(data))
            {
                return true;
            }

            current = current.next;
        }

        return false;
    }

    public void addfirst(t data)
    {
        node<t> newnode = new node<t>(data);
        node<t> current = head;

        newnode.next = current;
        head = newnode;
    }



}

#endregion