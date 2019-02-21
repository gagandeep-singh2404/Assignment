package client;

import java.util.Iterator;
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
public class Main {

    public static void main(String[] args) {
        Restaurant china = new Restaurant("Mei Ling");
        china.printMenu();
        china.openRestaurant();
        int rounds = 1;
        if (args.length > 0)
            try {
                rounds = Integer.parseInt(args[0]);
            } catch (Exception whateverItakethatasas1) {
            }

        MrBigAppetite mrBig = new MrBigAppetite(china.getMenu(), rounds);

        Thread process;
        Thread serve;

        china.setCustomer(mrBig);
        for (int r = 0; r < rounds; r++) {
            
            process = new Thread(new Runnable() {
                @Override
                public void run() {
                    china.procesOrders();
                }
            });

            serve = new Thread(new Runnable() {
                @Override
                public void run() {
                    china.serveReadyMeals();
                }
            });

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

            process.start();
            serve.start();

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

            
            process = new Thread(new Runnable() {
                @Override
                public void run() {
                    china.procesOrders();
                }
            });

            serve = new Thread(new Runnable() {
                @Override
                public void run() {
                    china.serveReadyMeals();
                }
            });
            
            process.start();
            serve.start();

            try {
                process.join();
                serve.join();
            } catch (InterruptedException ex) {
                Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
            }

        }
        System.out.println(mrBig.areYouSattisfied("Are you sattisfied?"));
        china.closeRestaurant();
    }

}
