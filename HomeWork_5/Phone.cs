using System;

// Класс Phone.  
//Создайте класс Phone, который содержит переменные number, model и  weight.  
//Создайте три экземпляра этого класса.  
// Выведите на консоль значения их переменных.  
// Добавить в класс Phone методы: receiveCall, имеет один параметр – имя  звонящего. 
//Выводит на консоль сообщение “Звонит {name}”. getNumber –  возвращает номер телефона. 
//Вызвать эти методы для каждого из  объектов.  
//Добавить конструктор в класс Phone,
//который принимает на вход три  параметра для инициализации переменных класса - number, model и  weight.  
//Добавить конструктор, который принимает на вход два параметра для  инициализации переменных класса - number, model.  
//Добавить конструктор без параметров.  
//Вызвать из конструктора с тремя параметрами конструктор с двумя.  Добавьте перегруженный метод receiveCall, 
//который принимает два  параметра - имя звонящего и номер телефона звонящего. Вызвать этот  метод.  
//Создать метод sendMessage с аргументами переменной длины. Данный  метод принимает на вход номера телефонов, 
//которым будет отправлено  сообщение. Метод выводит на консоль номера этих телефонов.  
public class Phone
{

    public string Number;
    public string Model;
    public double Weight;

    public Phone() { }

	public Phone(string number, string model)
	{
		Number = number;
		Model = model;
	}

	public Phone(string number, string model, double weight) : this(number, model) 
	{
		Weight = weight;
	}

	public void ReceiveCall(string name)
	{
		Console.WriteLine($"Звонит: {name}");
	}

	public void ReceiveCall (string name,string number)
	{
		Console.WriteLine($"Звонит: {name}, с номера: {number}");
	}

	public string GetNumber()
	{
		return Number;
    }

	public void SendMessage(params string[] numbers)
	{
		foreach (string number in numbers)
		{
			Console.WriteLine(number);
		}
	}
}
