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

        assertArrayEquals(input,output);
    }

    @Test
    public void bubble() throws Exception {
        int[] input = {9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.bubble(input);

        assertArrayEquals(input,output);
    }

    @Test
    public void select() throws Exception{
        int[] input = {9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.select(input);

        assertArrayEquals(input,output);
    }

    @Test
    public void insert() throws Exception{
        int[] input = {0,9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.insert(input);

        input = java.util.Arrays.copyOfRange(input,1,input.length);

        assertArrayEquals(input,output);
    }

    @Test
    public void shell() throws Exception{
        int[] input = {0,9, 1, 5, 8, 3, 7, 4, 6, 2};
        int[] output = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        Sort.shell(input);

        input = java.util.Arrays.copyOfRange(input,1,input.length);

        assertArrayEquals(input,output);
    }

}