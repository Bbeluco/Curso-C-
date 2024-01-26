namespace ReferencesAndOut;

public class Calculator {
    public static void Triple(ref int a) {
        a *= 3;
    }

    public static void Double(int origin, out int b) {
        b = origin * 2;
    }
}
