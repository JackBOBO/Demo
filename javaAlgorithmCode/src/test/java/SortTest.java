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
        int[] input = {0, 50, 10, 90, 30, 70, 40, 80, 60, 20};
        int[] output = {0, 10, 20, 30, 40, 50, 60, 70, 80, 90};

        Sort.heapSort(input);

        assertArrayEquals(input, output);
    }

}