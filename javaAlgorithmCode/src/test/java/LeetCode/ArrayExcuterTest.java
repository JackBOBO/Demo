package LeetCode;

import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by chenlong on 14/01/2018.
 */
public class ArrayExcuterTest {

    @Test
    public void RemoveElement() throws Exception {
        int[] input = {1,2,2,3,2,4};

        int output = ArrayExcuter.RemoveElement(input,6,2);

        assertEquals(output,3);

    }

    @Test
    public void removeDuplicates() throws Exception {
        int[] input = {1,1,2,3};

        int output = ArrayExcuter.RemoveDuplicates(input,4);

        assertEquals(output,3);
    }

}