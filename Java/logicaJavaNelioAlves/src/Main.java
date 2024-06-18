import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		System.out.println("Olá mundo");
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		String nome;
		int idade;
		double salario , altura;
		char genero;
		String generoFormatado;
		
		System.out.print("Type your name: ");
		nome = sc.nextLine();
		System.out.print("Type your age: ");
		idade = sc.nextInt();
		System.out.print("Type how much your earn in the mouth: ");
		salario = sc.nextDouble();
		System.out.print("Type your to height: ");
		altura = sc.nextDouble();
		System.out.print("Type your sex: ");
		genero = sc.next().charAt(0);
		
		System.out.println("Nome : " + nome);
		System.out.println("Idade : " + idade);
		System.out.println("Salario : " + String.format("%.2f", salario));
		System.out.println("Altura: " + String.format("%.2f", altura)); 
		
		if (genero == 'M' || genero == 'm') {
			
			generoFormatado = "Man";
		}
		else {
			generoFormatado = "Woman";
		}
		
		System.out.println("The employer " + nome + " have " + idade + " years old and earn " + salario + 
				" from sx " + generoFormatado + " of to height " + altura);
	
		
		sc.close();
	}

}
