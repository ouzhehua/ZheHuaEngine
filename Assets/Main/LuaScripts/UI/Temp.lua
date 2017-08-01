Temp = class(BasePage)


function Temp:Awake()
	Debug.LogError("hello world zhehua UI")
	Debug.LogError(self.pic.name.."  hello world zhehua UI")
	local haha = self.pic:GetComponent("UISprite");
	haha.spriteName = "Emoticon - Laugh";
	Debug.LogError(haha.name);
end

return Temp