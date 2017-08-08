Temp = class(BasePage)

function Temp:Awake()
	Debug.LogError("hello world zhehua UI")
	
	local sprite = self.pic:GetComponent("UISprite");
	sprite.spriteName = "Emoticon - Laugh";
	Debug.LogError(sprite.name);

	self.Coroutine = XluaUtil.cs_generator(function ()
		self:CoroutineFunc()
	end)

	local button = self.pic:GetComponent("UIButton");

	AddDelegate(self.pic:GetComponent("UIButton").onClick, function()
		Debug.LogError("hello world UIButton")
		-- 不好使
		-- self.parent:StopCoroutine(self.Coroutine)
		self.parent:StopAllCoroutines()
	end)

	self.parent:StartCoroutine(self.Coroutine)
end

function Temp:CoroutineFunc()
	print('coroutine start!')
	local s = os.time()

	coroutine.yield(CS.UnityEngine.WaitForSeconds(3))
	print('wait interval:', os.time() - s)

	local www = CS.UnityEngine.WWW('http://www.qq.com')
	coroutine.yield(www)
	if not www.error then
		print(www.bytes)
	else
		print('error:', www.error)
	end

	while(true) do
		coroutine.yield(CS.UnityEngine.WaitForSeconds(1))
		print("zou ni "..self.parent.name)
	end
end

return Temp