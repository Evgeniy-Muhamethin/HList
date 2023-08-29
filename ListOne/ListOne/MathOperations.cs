using System.Text;
using System.Text.Encodings;

namespace ListOne
{
	internal class MathOperations
	{
		public void UpdateMathOperation()
		{
			//Вызываю метод асинхронного выполнения операции 
			MathOperationsMethodAsync();
		}

		//Создаю метод асинхронного выполнения операции 
		//Это обертка для методы выполняющего операции
		private async void MathOperationsMethodAsync()
		{
			await Task.Run(() => MathOperationsMethod(10,15));
		}

		//Создаю метод выполняющий операции
		private void MathOperationsMethod(int numberOne, int numberTwo)
		{
			DateTime dateTimeStart = DateTime.Now;
			int count = int.MaxValue;
			int countResult = 0;
			while (count != 0)
			{
				int result = numberOne + numberTwo;
				count--;
				countResult += result;
			}
			DateTime dateTimeStop = DateTime.Now;
			var timeOperations = dateTimeStart - dateTimeStop;
			using (var sw = new StreamWriter("MathOperationsLog.txt",true, Encoding.UTF8))
			{
				sw.WriteLine($"count result operations = {countResult},\n" +
					$"time was executed = {timeOperations}");
			}
			Console.WriteLine($"Count result = {countResult}\n" +
					$"Time {timeOperations}");
        }
	}
}
