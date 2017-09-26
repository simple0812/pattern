using System;

public class PlayContext {
	private string text;
	public string PlayText{
		get {return text;}
		set {text = value;}
	}
}

abstract class Expression {
	public void Interpret(PlayContext context){
		if(context.PlayText.Length == 0) return;

		string playKey = context.PlayText.Substring(0,1);
		context.PlayText = context.PlayText.Substring(2);

		var playValue = Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ")));
		context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ") + 1);

		Excute(playKey, playValue);
	}

	public abstract void Excute(string key, double value);
}

class Scale : Expression {
	public override void Excute(string key, double value) {
		string note = "";
		switch (key) {
			case "C": note = "1"; break;
			case "D": note = "2"; break;
			case "E": note = "3"; break;
			case "F": note = "4"; break;
			case "G": note = "5"; break;
			case "A": note = "6"; break;
			case "B": note = "7"; break;
			default:
			  break;
		}

		Console.Write(note + " ");
	}
}

class Note : Expression {
	public override void Excute(string key, double value) {
		string scale = "";
		switch (value+"") {
			case "1": scale = "低音"; break;
			case "2": scale = "中音"; break;
			case "3": scale = "高音"; break;
			default:
			  break;
		}

		Console.Write(scale + " ");
	}
}

public class Program{
	static void Main(){
		PlayContext context = new PlayContext();
		Console.WriteLine("上海滩:");
		context.PlayText = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 ";
		Expression expression = null;

		try {
			while (context.PlayText.Length > 0) 
			{
				string str = context.PlayText.Substring(0,1);
				switch (str) 
				{
					case "O": expression = new Note();break;
					case "C": expression = new Scale();break;
					case "D": expression = new Scale();break;
					case "E": expression = new Scale();break;
					case "F": expression = new Scale();break;
					case "G": expression = new Scale();break;
					case "A": expression = new Scale();break;
					case "B": expression = new Scale();break;
					case "P": expression = new Scale();break;
					default:
					  break;
				}

				expression.Interpret(context);
			}
		} catch(Exception e) {
			Console.WriteLine(e.Message);
		}

		Console.Read();
	}
}