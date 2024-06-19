import java.util.Locale;
import java.util.Scanner;

public class MatrizesEmJava {
	
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		Locale.setDefault(Locale.US);
	
//		int m, n;
//		
//		System.out.println("how many lines will be there? ");
//		m = sc.nextInt();
//		System.out.println("how many colluns will be there?");
//		n = sc.nextInt();
//		
//		int[][] mat = new int[m][n];
//		
//		for (int i = 0; i < m; i++) {
//			for (int j = 0; j < n; j++) {
//				System.out.println("[" + i + "]" + "," + "[" + j + "]" + " :" );
//				mat[i][j] = sc.nextInt();
//			}
//		}
//		
//		for (int i = 0; i < m; i++) {
//			for (int j = 0; j < n; j++) {
//				System.out.print(mat[i][j] + " ");
//			}
//			System.out.println(" ");
//		}
		
		
		
//		int m;
//		int negatives = 0;
//		
//		System.out.println("What's the order of the matrix");
//		m = sc.nextInt();
//		
//		int[][] mat = new int[m][m];
//		
//		for (int i = 0; i < m; i++) {
//			for (int j = 0; j < m; j++) {
//				System.out.println("Element " + "["+ i + "," + j + "]:" );
//				mat[i][j] = sc.nextInt();
//			}
//		}
//		
//		System.out.println("The main diagonal from the matrix: ");
//		
//		for (int i = 0; i < m; i++) {
//			for (int j = i; j == i; j++) {
//				System.out.print(mat[i][j] + " ");
//			}
//			System.out.println(" ");
//		}
//		
//		for (int i = 0; i < m; i++) {
//			for (int j = 0; j < m; j++) {
//				if (mat[i][j] < 0) {
//					negatives = negatives + 1;
//				}
//			}
//		}
//		
//		System.out.println("Number of negatives in the matrix: " + negatives);
//		
//		
		
		
		int m, n;
		double sum1 = 0, sum2 = 0;
		
		System.out.println("how many lines will be there? ");
		m = sc.nextInt();
		System.out.println("how many colluns will be there?");
		n = sc.nextInt();
		
		double[][] mat = new double[m][n];
		
		for (int i = 0; i < m; i++) {
			System.out.println("Type the elements from the " + i + "a. line:");
			for (int j = 0; j < n; j++) {
				mat[i][j] = sc.nextDouble();
			}
		}
		
		for (int i = 0; i == 0;i++) {
			for (int j = 0; j < n; j++) {
				sum1 = sum1 + mat[i][j];
			}
		}
		for (int i = 1; i < m;i++) {
			for (int j = 0; j < n; j++) {
				sum2 = sum2 + mat[i][j];
			}
		}
		
		System.out.println("Generated vector:");
		System.out.println(String.format("%.1f", sum1));
		System.out.println(String.format("%.1f", sum2));
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		sc.close();
	}
}