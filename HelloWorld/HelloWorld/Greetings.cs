using System;
using System.Collections.Generic;

namespace HelloWorld
{
	public class Greetings
	{
		static List<string> values = new List<string> {
			"Hello World",
			"Hola Mundo",
			"ਸਤਿ ਸ੍ਰੀ ਅਕਾਲ ਦੁਨਿਆ",
			"こんにちは世界",
			"你好世界",
			"Përshendetje Botë",
			"مرحبا بالعالم",
			"Բարեւ, աշխարհ",
			"হ্যালো দুনিয়া",
			"Saluton mondo",
			"გამარჯობა მსოფლიო",
		};

		static Random rand = new Random();

		public static string GetGreeting() {
			int index = rand.Next (values.Count);
			return values[index];
		}
	}
}

