package client;

import java.util.Iterator;
import java.util.concurrent.Executor;
import java.util.concurrent.ScheduledThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;
import java.util.logging.Logger;
import restaurant.Restaurant;
import restaurant.RestaurantException;
import static restaurant.Utils.*;

/**
 * Restaurant driver class. This implements Donalds orginal 'algorithm', take
 * two orders, cook and serve them, all in a loop until the customer is
 * satisfied.
 *
 * @author ode
 * @author hom
 */
public class Main implements Executor {

    public static void main(String[] args) {
        try {
            Restaurant china = new Restaurant("Mei Ling");
            china.printMenu();
            china.openRestaurant();
            
            Runnable prozess = new Thread((Runnable) () -> {
                china.procesOrders();
            });
            
            Runnable serve = new Thread((Runnable) () -> {
                china.serveReadyMeals();
            });
            
            ScheduledThreadPoolExecutor pool = new ScheduledThreadPoolExecutor(2);
            
            int rounds = 1;
            if (args.length > 0)
                try {
                    rounds = Integer.parseInt(args[0]);
                } catch (Exception whateverItakethatasas1) {
                }
            MrBigAppetite mrBig = new MrBigAppetite(china.getMenu(), rounds);
            
            for (int r = 0; r < rounds; r++) {
                
                pool.scheduleAtFixedRate(prozess, 0, 10, TimeUnit.MILLISECONDS);
                pool.scheduleAtFixedRate(serve, 0, 10, TimeUnit.MILLISECONDS);
                
                try {
                    china.submitOrder(mrBig.wouldLike());
                } catch (RestaurantException e) {
                    System.out.println(e.getMessage());
                }
                try {
                    china.submitOrder(mrBig.wouldLike());
                } catch (RestaurantException e) {
                    System.out.println(e.getMessage());
                }
                
                try {
                    china.submitOrder(mrBig.wouldLike());
                } catch (RestaurantException e) {
                    System.out.println(e.getMessage());
                }
                try {
                    china.submitOrder(mrBig.wouldLike());
                } catch (RestaurantException e) {
                    System.out.println(e.getMessage());
                }
                
            }
            
            System.out.println(mrBig.areYouSattisfied("Are you sattisfied?"));
            china.closeRestaurant();
            pool.shutdown();
            pool.awaitTermination(10, TimeUnit.SECONDS);
        } catch (InterruptedException ex) {
            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @Override
    public void execute(Runnable command) {

    }
    
    
    
    public static double getGewischt(){
        return 0;
    }
    public static float getGewischt(){
        return 0;
    }
}
