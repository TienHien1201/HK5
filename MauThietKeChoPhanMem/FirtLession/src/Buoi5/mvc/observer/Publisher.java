package Buoi5.mvc.observer;

import java.util.LinkedList;
import java.util.List;

public class Publisher {
    private List<Subrcriber> subscribers = new LinkedList<>();

    public void addSubcribers(Subrcriber subcribers) {
        this.subscribers.add(subcribers);
    }

    public void unSubscribe(Subrcriber subcribers) {
        this.subscribers.remove(subcribers);
    }

    public void notifySubcribers() {
        for (Subrcriber subrcriber : subscribers) {
            subrcriber.update();
        }
    }
}
