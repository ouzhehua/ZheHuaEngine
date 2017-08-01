TestRotate = class(BasePage)

function TestRotate:ctor()
    
end

function TestRotate:Update()
	self.transform:Rotate(Vector3(0,1,1));
	self:Test();
end

function TestRotate:Test()
	-- Debug.LogError(self.gameObject.name)
end

return TestRotate