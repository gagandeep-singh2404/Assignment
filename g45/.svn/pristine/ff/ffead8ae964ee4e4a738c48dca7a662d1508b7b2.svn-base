/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package appointmentplanner;

import appointmentplanner.util.Stack;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author gagandeepsingh
 */
public class StackTest {

    Appointment one = new Appointment("1", new TimeSpan(0, 20));
    Appointment two = new Appointment("2", new TimeSpan(0, 20));
    Appointment three = new Appointment("3", new TimeSpan(0, 20));
    Appointment four = new Appointment("4", new TimeSpan(0, 20));
    Appointment five = new Appointment("5", new TimeSpan(0, 20));
    Appointment six = new Appointment("6", new TimeSpan(0, 20));
    Stack stack = new Stack();

    public StackTest() {
    }

    @BeforeClass
    public static void setUpClass() {
    }

    @AfterClass
    public static void tearDownClass() {
    }

    @Before
    public void setUp() {

    }

    @After
    public void tearDown() {
    }

    // TODO add test methods here.
    // The methods must be annotated with annotation @Test. For example:
    //
    // @Test
    // public void hello() {}
    @Test
    public void sizeTest() {

        assertTrue(stack.isEmpty());
        stack.push(one);
        stack.push(two);
        stack.push(three);
        stack.push(four);
        stack.push(five);
        stack.push(six);

        assertEquals(6, stack.size());

        stack.pop();
        stack.pop();
        assertEquals(4, stack.size());

        stack.push(five);
        assertEquals(5, stack.size());
    }

    @Test
    public void testPush() {

        stack.push(one);
        stack.push(two);
        assertFalse(stack.isEmpty());
        assertEquals(2, stack.size());
        assertEquals(stack.pop(), two);
        stack.pop(); 
        assertTrue(stack.isEmpty());
        assertEquals(0,stack.size());
        
        assertNull(stack.pop());
        
        
    }
    
    
    

}
