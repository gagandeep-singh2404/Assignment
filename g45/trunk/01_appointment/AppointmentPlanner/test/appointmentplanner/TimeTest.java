/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package appointmentplanner;

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
public class TimeTest {

    public TimeTest() {
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

    /**
     *
     * tests the method correctNegativeTime
     *
     *
     */
    @Test
    public void getProperTimeTest() {

        Time firstNegativeTime = Time.getProperTime(-5, 40);
        Time firstExpected = new Time(0,0);
        assertEquals(firstExpected, firstNegativeTime);

        Time secondNegativeTime = Time.getProperTime(-5, -59);
        Time secondExpected = new Time(0, 0);
        assertEquals(secondExpected, secondNegativeTime);

        Time thirdNegativeTime = Time.getProperTime(5, -45);
        Time thirdExpected = new Time(4, 15);
        assertEquals(thirdExpected, thirdNegativeTime);

        Time fourthNegtativeTime = Time.getProperTime(-4, 77);
        Time fourthExpected = new Time(0,0);
        assertEquals(fourthExpected, fourthNegtativeTime);

        Time fifthNegativeTime = Time.getProperTime(5, -120);
        Time fifthExpected = new Time(03, 00);
        assertEquals(fifthExpected, fifthNegativeTime);


        Time seventhNegativeTime = Time.getProperTime(5, 12);
        Time seventhExpected = new Time(5, 12);
        assertEquals(seventhExpected, seventhNegativeTime);

      
        Time ninethNegativeTime = Time.getProperTime(23, 77);
        Time ninethExpected = new Time(00, 17);
        assertEquals(ninethExpected, ninethNegativeTime);
        
        Time lo = Time.getProperTime(12, -65); 
        System.out.println(lo.getHours()+" " +lo.getMinutes());
   
    }

    @Test
    public void addTime() {

        Time firstAddTime = new Time(1, 00);
        Time firstExpected = new Time(3, 00);
        assertEquals(firstExpected, firstAddTime.addTime(new Time(2, 00)));

        Time secondAddTime = new Time(3, 45);
        Time secondExpected = new Time(5, 00);
        assertEquals(secondExpected, secondAddTime.addTime(new Time(1, 15)));

        Time thirdAddTime = new Time(-10, 55);
        Time thirdExpected = new Time(1, 00);
        assertEquals(thirdExpected, thirdAddTime.addTime(new Time(11, -55)));

        Time fourthAddTime = new Time(5, 44);
        Time fourthExpected = new Time(0,0);
        assertEquals(fourthExpected, fourthAddTime.addTime(new Time(-6, -10)));

        Time fifthAddTime = new Time(5, 50);
        Time fifthExpected = new Time(6, 30);
        assertEquals(fifthExpected, fifthAddTime.addTime(new Time(0, 40)));
    }

    @Test
    public void isBeforeTest() {
        Time firstBefore = new Time(1, 00);
        assertTrue(firstBefore.isBefore(new Time(3, 00)));

        Time secondBefore = new Time(7, 17);
        assertTrue(secondBefore.isBefore(new Time(7, 19)));

        Time thirdBefore = new Time(7, 00);
        assertFalse(thirdBefore.isBefore(new Time(6, 19)));

        Time fourthBefore = new Time(1, 44);
        assertFalse(fourthBefore.isBefore(new Time(1, 33)));

    }
    
    @Test
    public void equalsTest(){
        Time firstTime = new Time(1,00); 
        
        
        assertFalse(firstTime.equals(new Time(2,00)));
        assertTrue(firstTime.equals(new Time(1,00)));
        assertFalse(firstTime.equals(new TimeSpan(1, 00)));
        
       
    }
    
    @Test 
    public void hashCodeTest(){
        
        Time first = new Time(1,00); 
        Time second = new Time(6,00); 
        Time third = new Time(1,00); 
        
        int result = first.hashCode(); 
        
        
        assertEquals(result,third.hashCode());
        assertFalse(result == second.hashCode());
    }
}