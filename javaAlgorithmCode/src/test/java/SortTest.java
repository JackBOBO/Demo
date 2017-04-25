import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by chenlong on 2017/4/16.
 */
public class SortTest {
    @Test
    public void base() throws Exception {
        int[] input = {9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.base(input);

        assertArrayEquals(input, output);
    }

    @Test
    public void bubble() throws Exception {
        int[] input = {9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.bubble(input);

        assertArrayEquals(input, output);
    }

    @Test
    public void select() throws Exception {
        int[] input = {9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.select(input);

        assertArrayEquals(input, output);
    }

    @Test
    public void insert() throws Exception {
        int[] input = {0, 9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.insert(input);

        input = java.util.Arrays.copyOfRange(input, 1, input.length);

        assertArrayEquals(input, output);
    }

    @Test
    public void shell() throws Exception {
        int[] input = {0, 9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.shell(input);

        input = java.util.Arrays.copyOfRange(input, 1, input.length);

        assertArrayEquals(input, output);
    }

    @Test
    public void heapSort() {
        int[] input1 = {0, 50, 10, 90, 30, 70, 40, 80, 60, 20};
        int[] output1 = {10, 20, 30, 40, 50, 60, 70, 80, 90};

        int[] input2 = {0, 0, 52, 11, 10, 90, 30, 50, 70, 33, 40, 80, 60, 20};
        int[] output2 = {0, 10, 11, 20, 30, 33, 40, 50, 52, 60, 70, 80, 90};


        Sort.heapSort(input1);
        Sort.heapSort(input2);


        input1 = java.util.Arrays.copyOfRange(input1, 1, input1.length);
        input2 = java.util.Arrays.copyOfRange(input2, 1, input2.length);

        assertArrayEquals(input1, output1);
    }

    @Test
    public void mergeSort() {
        int[] input = {50, 10, 90, 30, 70, 40, 80, 60, 20};
        int[] output = {10, 20, 30, 40, 50, 60, 70, 80, 90};

        Sort.mergeSort(input);

        assertArrayEquals(input, output);
    }

    @Test
    public void quickSort() {
        int[] input = {50, 10, 90, 30, 70, 40, 80, 60, 20};
        int[] output = {10, 20, 30, 40, 50, 60, 70, 80, 90};

        Sort.quickSort(input);

        assertArrayEquals(input, output);
    }

}