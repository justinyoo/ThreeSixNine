import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class ThreeSixNine {
	/**
	 * main
	 * @param args
	 */
	public static void main(String[] args) {
		String regex = "[^369]*[369]+?[^369]*";
		for (int i = 1; i < 100; i++) {
			String stringI = new String().valueOf(i);
			Pattern pattern = Pattern.compile(regex);
			Matcher  matcher = pattern.matcher(stringI);
			int matchCount = getMatchCount(matcher);
			
			if(matcher.matches()){
				for (int j = 0; j < matchCount; j++) {
					System.out.print("clap ");
				}
				System.out.println("("+i+")");
			}else{
				System.out.println(i);
			}
		}
	}
	
	/**
	 * 매치카운트 반환 method
	 * @param matcher
	 * @return
	 */
	public static int getMatchCount(Matcher  matcher){
        int count = 0;
        
        while (matcher.find())
            count++;
        
        return count;
	}
}
