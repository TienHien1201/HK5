package Buoi5.mvc.command;

public class CommandProcessor {
    // filed
    private static CommandProcessor commandProcessorRemote = null;
    
    // method
    private CommandProcessor(){}

    public static CommandProcessor makeCommanProcessor(){
if (commandProcessorRemote == null) {
    commandProcessorRemote = new CommandProcessor();
}
return commandProcessorRemote;
    }

public void excute(Command cmd){
cmd.excute();
}
}
