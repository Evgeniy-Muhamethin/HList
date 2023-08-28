namespace ListOne
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MainClass mainClass = new MainClass();
			MathOperations mathOperations = new MathOperations();
			mathOperations.UpdateMathOperation();
			mainClass.Start();
			mainClass.Update();
		}
	}
}