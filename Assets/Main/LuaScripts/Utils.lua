function NewLuaInstanceByPath(luaClassPath)
    local luaClass = require(luaClassPath)
    if luaClass == nil then
        error("without "..luaClassPath..".lua")
    end

    local luaInstance = luaClass.new()
    if luaInstance == nil then
        error("can not new "..luaClassPath..".lua")
    end
    return luaInstance
end

function AddDelegate(delegateList, func)
    LuaScriptUtil.Add_NGUI_Delegate(delegateList, func)
end

function SetDelegate(delegateList, func)
    LuaScriptUtil.Set_NGUI_Delegate(delegateList, func)
end

function SetLayerRecursively(target, layerName)
    target.gameObject.layer = LayerMask.NameToLayer(layerName)
    for i = 0, target.childCount - 1 do
        SetLayerRecursively(target:GetChild(i), layerName)
    end
end

function string:split(sep)
    local sep, fields = sep or ":", {}
    local pattern = string.format("([^%s]+)", sep)
    self:gsub(pattern, function(c) fields[#fields+1] = c end)
    return fields
end

function split(s, delim)
    if type(delim) ~= "string" or string.len(delim) <= 0 then
        return
    end

    local start = 1
    local t = {}
    while true do
    local pos = string.find (s, delim, start, true) -- plain find
        if not pos then
          break
        end

        table.insert (t, string.sub (s, start, pos - 1))
        start = pos + string.len (delim)
    end
    table.insert (t, string.sub (s, start))

    return t
end

function string.empty(str)
    return str == nil or str == ''
end

function table.contains(table, element)
    if table == nil then
        return false
    end
  
    for _, value in pairs(table) do
      if value == element then
        return true
      end
    end
    return false
end

-- RemoveByValue only applies to array-type tables
function table.removeByValue(t, value)
    if t then
        for i,v in ipairs(t) do 
            if v == value then
                table.remove(t, i)
            end
        end
    end
end

function table.size(t)
    if t == nil then
        print("nil table in table.size");
        return 0; 
    end
    local s = 0;
    for k,v in pairs(t) do
        if v ~= nil then s = s+1; end
    end
    return s;
end

function table.tostring(tbl, indent, limit, depth, jstack)
    limit   = limit  or 1000
    depth   = depth  or 7
    jstack  = jstack or {name="top"}
    local i = 0

    local output = {}
    if type(tbl) == "table" then
        -- very important to avoid disgracing ourselves with circular referencs...
        for i,t in pairs(jstack) do
            if tbl == t then
                return "<" .. i .. ">,\n"
            end
        end
      jstack[jstack.name] = tbl

      table.insert(output, "{\n")

      local name = jstack.name
      for key, value in pairs(tbl) do
          local innerIndent = (indent or " ") .. (indent or " ")
          table.insert(output, innerIndent .. tostring(key) .. " = ")
          jstack.name = name .. "." .. tostring(key)
          table.insert(output,
            value == tbl and "<parent>," or table.tostring(value, innerIndent, limit, depth, jstack)
          )

          i = i + 1
          if i > limit then
              table.insert(output, (innerIndent or "") .. "...\n")
              break
          end
      end

      table.insert(output, indent and (indent or "") .. "},\n" or "}")
    else
        if type(tbl) == "string" then tbl = string.format("%q", tbl) end -- quote strings
        table.insert(output, tostring(tbl) .. ",\n")
    end

    return table.concat(output)
end

function table.clone(t, nometa)
    local u = {}

    if not nometa then
        setmetatable(u, getmetatable(t))
    end

    for i, v in pairs(t) do
        if type(v) == "table" then
          u[i] = table.clone(v, nometa)
        else
          u[i] = v
        end
    end

    return u
end

function table.insertIfNotExist(tbl, item)
    for k,v in pairs(tbl) do
        if v == item then
          return
        end
    end
    table.insert(tbl, item)
end

function deepcopy(object)
    local lookup_table = {}
    local function _copy(object)
        if type(object) ~= "table" then
            return object
        elseif lookup_table[object] then
            return lookup_table[object]
        end
        local new_table = {}
        lookup_table[object] = new_table
        for index, value in pairs(object) do
            new_table[_copy(index)] = _copy(value)
        end
        return setmetatable(new_table, getmetatable(object))
    end
    return _copy(object)
end

function math.clamp(input, min_val, max_val)
    if input < min_val then
        input = min_val
    elseif input > max_val then
        input = max_val
    end
    return input
end

function math.sign(x)
    if x > 0 then
        return 1
    elseif x < 0 then
        return -1
    else
        return 0
    end
end