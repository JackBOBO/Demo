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

        for (i = arr.length - 1; i > 2; i--) {
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

    public static void mergeSort(int[] arr) {
        mSort(arr, arr, 0, arr.length - 1);
    }

    private static void mSort(int[] sr, int[] tr1, int s, int t) {
        int m;
        int[] tr2 = new int[sr.length];
        if (s == t) {
            tr1[s] = sr[s];
        } else {
            m = (s + t) / 2;
            mSort(sr, tr2, s, m);
            mSort(sr, tr2, m + 1, t);
            merge(tr2, tr1, s, m, t);
        }
    }

    private static void merge(int[] sr, int[] tr, int i, int m, int n) {
        int j, k, l;

        for (j = m + 1, k = i; i <= m && j <= n; k++) {
            if (sr[i] < sr[j])
                tr[k] = sr[i++];
            else
                tr[k] = sr[j++];
        }

        if (i <= m) {
            for (l = 0; l <= m - i; l++)
                tr[k + l] = sr[i + l];
        }

        if (j <= n) {
            for (l = 0; l <= n - j; l++)
                tr[k + l] = sr[j + l];
        }
    }

    public static void mergeSort2(int[] arr) {
        int[] tr = new int[100];
        int k = 1;
        while (k < arr.length) {
            mergePass(arr, tr, k, arr.length-1);
            k = 2 * k;
            mergePass(tr, arr, k, arr.length-1);
            k = 2 * k;
        }
    }

    private static void mergePass(int[] sr, int[] tr, int s, int n) {
        int i = 1;
        int j;
        while (i < n - 2 * s + 1) {
            merge(sr, tr, i, i + s - 1, i + 2 * s + 1);
            i = i + 2 * s;
        }

        if (i < n - s + 1) {
            merge(sr, tr, i, i + s - 1, n);
        } else {
            for (j = i; j <= n; j++) {
                tr[j] = sr[j];
            }
        }
    }

    public static void quickSort(int[] arr) {
        qSort(arr, 0, arr.length - 1);
    }

    private static void qSort(int[] arr, int low, int high) {
        int pivot;
        if (low < high) {
            pivot = partition(arr, low, high);

            qSort(arr, low, pivot - 1);
            qSort(arr, pivot + 1, high);
        }
    }

    private static int partition(int[] arr, int low, int high) {
        int pivotKey = arr[low];
        while (low < high) {
            while (low < high && arr[high] >= pivotKey)
                high--;

            swap(arr, low, high);

            while (low < high && arr[low] <= pivotKey)
                low++;

            swap(arr, low, high);
        }

        return low;
    }


    private static void swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
