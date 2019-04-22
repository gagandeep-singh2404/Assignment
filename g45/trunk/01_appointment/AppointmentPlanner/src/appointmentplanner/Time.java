package appointmentplanner;

import java.text.DecimalFormat;

/**
 * A 24 hour Time class
 *
 * @author ode
 */
public final class Time {

    private final int hours;
    private final int minutes;

    /**
     * Constructor with two arguments: hours and minutes. No mercy for those who
     * do not follow the pre-conditions! Pre conditions are: - hours should be
     * in range 0..23 - minutes should be in range 0..59
     *
     * But: A static method is available that returns a Time object with
     * parameters that need not fulfill these conditions.
     *
     * @param hours the number of hours
     * @param minutes the number of minutes
     */
    public Time(int hours, int minutes) {
        this.hours = hours;
        this.minutes = minutes;

    }

    /**
     * Getter for hours of this Time.
     *
     * @return hours of this Time object
     */
    public int getHours() {
        return hours;
    }

    /**
     * Getter for minutes of this Time.
     *
     * @return minutes of this Time object
     */
    public int getMinutes() {
        return minutes;
    }

    /**
     * A given time is added to this time. The result is returned as a new Time
     * object.
     *
     * @param t The time that will be added to this time.
     * @return The Time object as a result of adding t to this time.
     */
    public Time addTime(Time t) {
        
        Time addedTime = new Time(this.getHours() + t.getHours(), this.getMinutes() + t.getMinutes());
        return Time.getProperTime(addedTime.getHours(), addedTime.getMinutes());
    }

    /**
     * This method actually tests if this time is before the given other time.
     *
     * @param otherTime The Time object to compare with.
     * @return true if the this time is before other.
     */
    public boolean isBefore(Time otherTime) {
       return (this.getHours() < otherTime.getHours() || (this.getHours() == otherTime.getHours() && this.getMinutes() < otherTime.getMinutes())); 
    }

    /**
     * Get your Time object here if you are in doubt if parameters are not in
     * the correct (proper) range: 0 &lt;= hrs &lt; 24 &amp; 0 &lt;= mts &lt;
     * 60. Negative hour values are 'normalized' to zero, negative minute values
     * are subtracted from the hours. Hour values that are too big are
     * normalized to values in range (e.g. 25 hours becomes 2 hours), an
     * overflow of minutes is added to the hours.
     *
     * @param hrs hour of the time object
     * @param mts minutes of the time object
     * @return a new Time object.
     */
    public static Time getProperTime(int hrs, int mts) {
        
        int minutes = hrs*60+mts; 
        int hours = minutes / 60; 
        
        if (minutes <= 0) {
            return new Time(0,0);
        }else {
            // restHours
            hours %= 24;
            // restMinutes 
            minutes %= 60; 
            return new Time(hours,minutes);
        }
    }

    /**
     * corrects the negative time houres negative == 0 hours negative minutes
     * deincrement hour, 60 -minutes
     *
     * @param hours the hours
     * @param minutes the minutes
     *
     * @return the Time Object
     */
    @Override
    public boolean equals(Object o) {
        if (!(o instanceof Time)) {
            return false;
        } else {
            Time t = (Time) o;
            return t.hours == this.hours && t.minutes == this.minutes;
        }
    }

    @Override
    public int hashCode() {
        int hash = 5;
        hash = 11 * hash + this.hours;
        hash = 11 * hash + this.minutes;
        return hash;
    }

    @Override
    public String toString() {
        DecimalFormat df = new DecimalFormat("00");
        return df.format(hours) + ":" + df.format(minutes);

    }

}