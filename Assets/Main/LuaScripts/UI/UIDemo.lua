UIDemo = class(BasePage)

function UIDemo:Awake()
	Debug.Log("hello world zhehua UI")
	
	local spriteFrame = self["SpriteFrame"]:GetComponent("UISprite");
	spriteFrame.spriteName = "Highlight - Thin";

	self.CoroutineFunc = XluaUtil.cs_generator(function ()
		self.numIndex = 0
		self:CoroutineFunction()
	end)


	AddDelegate(self["CoroutineBtn"]:GetComponent("UIButton").onClick, function()
		Debug.Log("Stop Coroutine")
		self.parent:StopCoroutine(self.CoroutineInstance)
	end)

	self.CoroutineInstance = self.parent:StartCoroutine(self.CoroutineFunc)

	AddDelegate(self["DotweenBtn"]:GetComponent("UIButton").onClick, function() self:OnDotweenBtn() end)

	local tweenTrigger = self["UITweenTrigger"]:GetComponent("UIEventTrigger")
	AddDelegate(tweenTrigger.onHoverOver, function() self:OnHoverOver() end)
	AddDelegate(tweenTrigger.onHoverOut, function() self:OnHoverOut() end)
end

function UIDemo:OnInit( ... )
	print("LuaUIForm OnInit")
end

function UIDemo:CoroutineFunction()
	Debug.Log('Coroutine Start!')
	local s = os.time()
	coroutine.yield(CS.UnityEngine.WaitForSeconds(1))
	Debug.Log('Wait Interval:', os.time() - s)

	local www = CS.UnityEngine.WWW('http://www.qq.com')
	coroutine.yield(www)
	if not www.error then
		Debug.Log(www.bytes)
	else
		Debug.Log('error:', www.error)
	end

	while(true) do
		coroutine.yield(0)
		-- test "self" in Coroutine
		self.numIndex = self.numIndex + 1
		if self.numIndex > 999 then
			self.numIndex = 0
		end
		self["NumLabel"]:GetComponent("UILabel").text = tostring(self.numIndex)
	end
end

function UIDemo:OnDotweenBtn()
	self["SpriteDotween"].transform:DOShakePosition(1,20,20)
end

function UIDemo:OnHoverOver()
	self["SpriteUITween"]:GetComponent("TweenWidth"):PlayForward()
end

function UIDemo:OnHoverOut()
	self["SpriteUITween"]:GetComponent("TweenWidth"):PlayReverse()
end

return UIDemo