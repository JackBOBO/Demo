/**
 * Created by chenlong on 2017/4/16.
 */
public class Sort {
    public static void base(int[] arr) {
        for (int i = 0; i < arr.length; i++) {

            for (int j = i + 1; j < arr.length; j++) {
                if (arr[i] > arr[j]) {
                    swap(arr, i, j);
                }
            }
        }

    }

    public static void bubble(int[] arr) {
        boolean flag = true;

        for (int i = 0; i < arr.length && flag; i++) {

            flag = false;
            for (int j = arr.length - 2; j >= i; j--) {

                if (arr[j] > arr[j + 1]) {
                    swap(arr, j, j + 1);
                    flag = true;
                }
            }
        }
    }

    public static void select(int[] arr) {
        int min = 0;

        for (int i = 0; i < arr.length; i++) {

            min = i;
            for (int j = i + 1; j < arr.length; j++) {
                if (arr[min] > arr[j])
                    min = j;
            }

            if (i != min)
                swap(arr, i, min);
        }
    }

    public static void insert(int[] arr) {
        int i, j;
        for (i = 2; i < arr.length; i++) {
            if (arr[i] < arr[i - 1]) {
                arr[0] = arr[i];

                for (j = i - 1; arr[j] > arr[0]; j--)
                    arr[j + 1] = arr[j];

                arr[j + 1] = arr[0];
            }
        }
    }

    public static void shell(int[] arr) {
        int i, j;
        int increment = arr.length;

        do {
            increment = increment / 3 + 1;

            for (i = increment + 1; i < arr.length; i++) {
                if (arr[i] < arr[i - increment]) {
                    arr[0] = arr[i];

                    for (j = i - increment; j > 0 && arr[0] < arr[j]; j -= increment) {
                        arr[j + increment] = arr[j];
                    }

                    arr[j + increment] = arr[0];
                }
            }

        } while (increment > 1);
    }

    public static void heapSort(int[] arr) {
        int i;

        for (i = arr.length / 2; i > 0; i--)
            heapAdjust(arr, i, arr.length);

        for (i = arr.length - 1; i > 1; i--) {
            swap(arr, 1, i);
            heapAdjust(arr, 1, i - 1);
        }
    }

    private static void heapAdjust(int[] arr, int s, int m) {
        int temp, j;
        temp = arr[s];

        for (j = 2 * s; j < m; j *= 2) {
            if (j < m && arr[j] < arr[j + 1])
                j++;

            if (temp >= arr[j])
                break;

            arr[s] = arr[j];
            s = j;
        }

        arr[s] = temp;
    }

    private static void swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
