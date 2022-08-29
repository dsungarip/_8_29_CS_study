using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2016년 월,일 입력시 요일을 알려주는 프로그램

namespace _8_29_CS_study
{
	internal class Program
	{
		public static string solution(int a, int b)
		{
			int sum = b;

			for (int i = 1; i < a; i++)
			{
				if (i == 2) { sum += 29; }
				else if (i < 8)
				{
					if (i % 2 == 1) { sum += 31; }
					else { sum += 30; }
				}
				else
				{
					if (i % 2 == 0) { sum += 31; }
					else { sum += 30; }
				}
			}

			switch (sum % 7)
			{
				case 0: return "THU";
				case 1: return "FRI";
				case 2: return "SAT";
				case 3: return "SUN";
				case 4: return "MON";
				case 5: return "TUE";
				case 6: return "WED";
				default: break;
			}
			return "ERROR";
		}
		static void Main(string[] args)
		{
			solution(5, 24);
		}
	}
}
