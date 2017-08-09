Temp = class(BasePage)

function Temp:Awake()
	Debug.LogError("hello world zhehua UI")
	
	local sprite = self.pic:GetComponent("UISprite");
	sprite.spriteName = "Emoticon - Laugh";
	Debug.LogError(sprite.name);

	self.CoroutineFunc = XluaUtil.cs_generator(function ()
		self:CoroutineFunction()
	end)

	local button = self.pic:GetComponent("UIButton");

	AddDelegate(self.pic:GetComponent("UIButton").onClick, function()
		Debug.LogError("Stop Coroutine")
		self.parent:StopCoroutine(self.CoroutineInstance)
	end)

	self.CoroutineInstance = self.parent:StartCoroutine(self.CoroutineFunc)
end

function Temp:OnInit( ... )
	Debug.LogError("Temp:OnInit")
end

function Temp:CoroutineFunction()
	print('coroutine start!')
	local s = os.time()

	coroutine.yield(CS.UnityEngine.WaitForSeconds(1))
	print('wait interval:', os.time() - s)

	local www = CS.UnityEngine.WWW('http://www.qq.com')
	coroutine.yield(www)
	if not www.error then
		print(www.bytes)
	else
		print('error:', www.error)
	end

	while(true) do
		coroutine.yield(0)
		print("zou ni "..self.parent.name)
	end
end

return Temp