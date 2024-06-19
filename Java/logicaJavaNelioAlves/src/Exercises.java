import java.util.Scanner;

public class Exercises {
    public static void main(String[] args) {
    	
        System.out.println("Hello, World!");
        
        
        Scanner sc = new Scanner(System.in);
        
        int n;
        
        System.out.print("How many numbers you'll type? ");
        
        n = sc.nextInt();
        
        int[] vet = new int[n];
        
        for (int i = 0; i < n; i++) {
        	System.out.print("Type a number: ");
        	vet[i] = sc.nextInt();
        }
        
        System.out.println("Numbers that have typed: ");
        for(int i = 0; i < n; i++) {
        	System.out.print(vet[i] + " ");
        }
        
        sc.close();
    }
}
