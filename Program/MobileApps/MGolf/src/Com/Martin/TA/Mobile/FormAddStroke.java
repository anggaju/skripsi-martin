/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package Com.Martin.TA.Mobile;

import javax.microedition.lcdui.Choice;
import javax.microedition.lcdui.ChoiceGroup;
import javax.microedition.lcdui.Command;
import javax.microedition.lcdui.CommandListener;
import javax.microedition.lcdui.Display;
import javax.microedition.lcdui.Displayable;
import javax.microedition.lcdui.Form;
import javax.microedition.lcdui.StringItem;
import javax.microedition.lcdui.TextField;

/**
 *
 * @author Martin
 */
public class FormAddStroke extends Form implements CommandListener{
    private Display display;
    private MGolf midlet;

    private String[] holeno = {"1", "2", "3", "4","5","6","7","8","9","10","11","12","13","14","15","16","17","18"};

    private String[] option = {"Tee Shoot", "Rest of Shoot"};

    private ChoiceGroup shot= new ChoiceGroup("Shoot", Choice.POPUP, option, null);
    private ChoiceGroup hole = new ChoiceGroup("Hole No:", Choice.POPUP, holeno, null);

    private TextField gameid = new TextField("Games ID", "ketik Games ID", 15, TextField.ANY);
    private TextField fir = new TextField("FIR", "", 5, TextField.NUMERIC);
    private TextField rr1 = new TextField("RR", "", 5, TextField.NUMERIC);
    private TextField lr1 = new TextField("LR", "", 5, TextField.NUMERIC);
    private TextField bunker1 = new TextField("Bunker", "", 5, TextField.NUMERIC);
    private TextField penalty1 = new TextField("Penalty", "", 5, TextField.NUMERIC);
    private TextField gir = new TextField("GIR", "", 5, TextField.NUMERIC);
    private TextField fairway = new TextField("Fairway", "", 5, TextField.NUMERIC);
    private TextField rr2 = new TextField("RR", "", 5, TextField.NUMERIC);
    private TextField lr2 = new TextField("LR", "", 5, TextField.NUMERIC);
    private TextField on_ = new TextField("ON", "", 5, TextField.NUMERIC);
    private TextField bunker2 = new TextField("Bunker", "", 5, TextField.NUMERIC);
    private TextField penalty2 = new TextField("Penalty", "", 5, TextField.NUMERIC);
    private TextField putts = new TextField("Putts", "", 5, TextField.NUMERIC);


    private final Command cmdKembali = new Command("Kembali", Command.BACK,1);
    private final Command cmdKirim = new Command("Kirim SMS", Command.SCREEN, 2);
    private final Command cmdLanjut = new Command("Lanjutkan", Command.SCREEN, 3);

    public FormAddStroke(MGolf midlet, Display display){
        super("Info Course");
        this.midlet = midlet;
        this.display = display;

        StringItem info = new StringItem("", "", StringItem.LAYOUT_LEFT);
        info.setText("Update stroke dari game yg telah dibuat.");

        this.append(info);
        this.append(shot);
        this.addCommand(cmdKembali);
        this.addCommand(cmdLanjut);
        this.setCommandListener(this);
        this.display.setCurrent(this);
    }

    public void commandAction(Command c, Displayable d) {
        if(c == cmdKembali){
            this.display.setCurrent(this.midlet.list);
        }else if(c == cmdLanjut){
            switch(shot.getSelectedIndex()){
                case 0:
                    this.deleteAll();
                    this.append(gameid);
                    this.append(fir);
                    this.append(rr1);
                    this.append(lr1);
                    this.append(bunker1);
                    this.append(penalty1);

                    this.removeCommand(cmdLanjut);
                    this.addCommand(cmdKirim);
                    break;
                case 1:
                    this.deleteAll();
                    this.append(gameid);
                    this.append(gir);
                    this.append(fairway);
                    this.append(rr2);
                    this.append(lr2);
                    this.append(bunker2);
                    this.append(penalty2);
                    this.append(on_);
                    this.append(putts);
                    
                    this.removeCommand(cmdLanjut);
                    this.addCommand(cmdKirim);
                    break;
            }
        }
    }

}
