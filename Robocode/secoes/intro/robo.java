package Robos;
import robocode.*;

// API help : https://robocode.sourceforge.io/docs/robocode/robocode/Robot.html

/*Essa classe eh seu roboh*/
public class MeuPrimeiroRobo extends Robot
{

	public void run() {
		
		// setColors(Color.red,Color.blue,Color.green); 
		// body,gun,radar

		// Robot main loop
		while(true) {
			// Replace the next 4 lines with any 
			//behavior you would like
			ahead(100);
			turnGunRight(360);
			back(100);
			turnGunRight(360);
		}
	}

	/**
	 * onScannedRobot: What to do when you see another robot
	 */
	public void onScannedRobot(ScannedRobotEvent e) {
		// Replace the next line with any behavior you would like
		fire(1);
	}

	/**
	 * onHitByBullet: What to do when you're hit by a bullet
	 */
	public void onHitByBullet(HitByBulletEvent e) {
		// Replace the next line with any behavior you would like
		back(10);
	}
	
	/**
	 * onHitWall: What to do when you hit a wall
	 */
	public void onHitWall(HitWallEvent e) {
		// Replace the next line with any behavior you would like
		back(20);
	}	
}
