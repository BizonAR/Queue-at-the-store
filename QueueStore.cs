using System;
using System.Collections.Generic;

namespace QueueStore
{
	internal class QueueStore
	{
		static void Main(string[] args)
		{
			Queue<int> queueStore = new Queue<int>();
			int cashAccount = 0;

			FillQueue(queueStore);
			ClearQueue(queueStore, cashAccount);
		}

		static void FillQueue(Queue<int> queueStore)
		{
			Random random = new Random();
			int maxValue = 10000;

			for (int i = 0; i < 10; i++)
				queueStore.Enqueue(random.Next(maxValue + 1));
		}

		static void ClearQueue(Queue<int> queueStore, int cashAccount)
		{
			while (queueStore.Count > 0)
			{
				cashAccount += queueStore.Dequeue();
				Console.WriteLine($"Счёт после покупки: {cashAccount}");

				Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
				Console.ReadKey();
			}
			Console.WriteLine("Больше покупателей нет");
		}
	}
}
