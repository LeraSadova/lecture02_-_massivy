Console.Clear();
//(1) заполняем массив
void FillArray(int[] collection) 
{
    int length=collection.Length; //получаем длину нашего массива
    int index=0; //берем позицию индекс и по умолчанию она будет начинаться с нолика
    while (index<length)
    {
        //обратиться к аргументу коллекция на позицию индекс 
        //и положить туда новое случайное целое число из диапазона 1...10
        collection[index]=new Random().Next(1,10);
        index++; // аналог index=index+1
        //в методе void мы ничего не возвращаем и не используем "return"
    }
}

//(2) печать массив
void PrintArray(int[] col) //тоже на вход массив, но его название col - просто другое взяли название)
{
    //обозначим количество элементов таким образом:
    int count=col.Length;
    int position=0; // текущую позицию побозначим позишион
    while (position<count)
    {
        Console.Write(col[position]); //выводить на экран значение текущего элемента
        Console.Write(", "); //чтобы выводили в строчку
        position++;
        //в методе void мы ничего не возвращаем и не используем "return"
    }
}

//(3) описываем метод, отличный от void. он будет возвращать нам индекс
int IndexOf(int[] collection, int find); //в качестве аргумента будет приходить collection и какой-то элемнт find
{
    int count=collection.Length;  //определяем количество элементов count
    int index=0;
    int position=0; //нам нужно куда-то сохранить найденную позицию

    while (index<count)
    {
        if (collection[index] == find)
        {
            position=index;
        }
        index++;
    }
    return position; //возвращаем значение
}



int [] array=new int [10]; //создай новый массив, в котором будет 10 элементов 

FillArray(array); // заполняем наш массив
PrintArray(array); //распечатывает наш массив
Console.WriteLine();

int pos = IndexOf(array, 4); //в эту переменную положим нашу найденное значение. 
Console.WriteLine(pos);

