--[[
	Murder Mystery 2 for Roblox game script
	 'Q' to toggle ESP
	 'E' to toggle noclip
	 'X' to toggle XRay
	 'M' for Murderer
	 'N' for Sheriff
	 'G' for god mode
	 'H' to toggle Infinite Jump
	 'Left ctrl' to teleport to location mouse is hovering on
	 'Shift' to sprint
--]]

local Players = game:GetService("Players")
local StarterGui = game:GetService("StarterGui")
local RunService = game:GetService("RunService")
local UserInputService = game:GetService("UserInputService")
local LocalPlayer = Players.LocalPlayer
local Mouse = LocalPlayer:GetMouse()

NoClip = false
XRay = false
ESP = false
InfiniteJump = false
RunService.Stepped:connect(function()
	if NoClip then
		LocalPlayer.Character.Humanoid:ChangeState(11)
	end
end)

function SendNotification(data)
	StarterGui:SetCore("SendNotification", data)
end

function FindPerson(role)
	for _, player in pairs(Players:GetChildren()) do
		if role == "Sheriff" then -- STUPID
			local gun = player.Backpack:FindFirstChild("Gun")
			local revolver = player.Backpack:FindFirstChild("Revolver")
			
			local gunM = player.Character:FindFirstChild("Gun")
			local revolverM = player.Character:FindFirstChild("Revolver")
			
			if gun or revolver or gunM or revolverM then
				return {
					UserId = player.UserId,
					Name = player.Name,
					Thumbnail = "https://roblox.com/Thumbs/Avatar.ashx?x=100&y=100&Format=Png&userid=" .. player.UserId
				}
			end
		elseif role == "Murderer" then
			local knife = player.Backpack:FindFirstChild("Knife")
			local knifeM = player.Character:FindFirstChild("Knife")
			if knife or knifeM then
				return {
					UserId = player.UserId,
					Name = player.Name,
					Thumbnail = "https://roblox.com/Thumbs/Avatar.ashx?x=100&y=100&Format=Png&userid=" .. player.UserId
				}
			end
		end
	end
	
	return false
end

function OnXray(obj)
	for _, object in pairs(obj:GetChildren()) do
		if object:IsA("BasePart") and not object.Parent:FindFirstChild("Humanoid") then
			if XRay then
				object.LocalTransparencyModifier = 0.75
			else
				object.LocalTransparencyModifier = 0
			end
		end
		OnXray(object)
	end
end

function ToggleXray()
	OnXray(workspace)
end

function ToggleNoClip()
	if LocalPlayer.Character and LocalPlayer.Character:FindFirstChild("Humanoid") and NoClip then
		LocalPlayer.Character.Humanoid:ChangeState(11)
	end
end

function GrabGun()
	if workspace:FindFirstChild("GunDrop") and LocalPlayer.Character:FindFirstChild("HumanoidRootPart") then
		workspace.GunDrop.CFrame = LocalPlayer.Character.HumanoidRootPart.CFrame
	end
end

function TeleportTo(position)
	LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(Vector3.new(position.x, position.y + 7, position.z))
end

function FindMurderer()
	local murderer = FindPerson("Murderer")
	if murderer then
		SendNotification({
			Title = "Murderer",
			Text = murderer.Name .. " (ID: ".. murderer.UserId ..") is the Murderer!",
			Duration = 5,
			Icon = murderer.Thumbnail,
			Button1 = "Dismiss"
		})
	else
		SendNotification({
			Title = "Murderer",
			Text = "Could not locate the Murderer!",
			Duration = 5,
			Button1 = "Dismiss"
		})
	end
end

function FindSheriff()
	local sheriff = FindPerson("Sheriff")
	if sheriff then
		SendNotification({
			Title = "Sheriff",
			Text = sheriff.Name .. " (ID: ".. sheriff.UserId ..") is the Sheriff!",
			Duration = 5,
			Icon = sheriff.Thumbnail,
			Button1 = "Dismiss"
		})
	else
		SendNotification({
			Title = "Sheriff",
			Text = "Could not locate the Sheriff!",
			Duration = 5,
			Button1 = "Dismiss"
		})
	end
end

function GunDropEvent(child)
	if child.Name == "GunDrop" then
		local callback = Instance.new("BindableFunction")
		callback.OnInvoke = function(arg)
			if arg == "Get gun!" then
				workspace.GunDrop.CFrame = CFrame.new(LocalPlayer.Character.HumanoidRootPart.Position)
			end
		end
		
		SendNotification({
			Title = "The sheriff has died!",
			Text = "Grab their gun?",
			Duration = 10,
			Button1 = "Dismiss",
			Button2 = "Get gun!",
			Icon = "https://www.roblox.com/asset?id=603594838",
			Callback = callback
		})
	end
end

function MakeNametag(base, r, g, b, teamName)
	local billboard = Instance.new("BillboardGui")
	billboard.Parent = base
	billboard.Adornee = base
	billboard.ExtentsOffset = Vector3.new(0,1,0)
	billboard.AlwaysOnTop = true
	billboard.Size = UDim2.new(0,5,0,5)
	billboard.StudsOffset = Vector3.new(0,1,0)
	billboard.Name = "tracker"
	
	local frame = Instance.new("Frame")
	frame.Parent = billboard
	frame.ZIndex = 10
	frame.BackgroundTransparency = 0.3
	frame.Size = UDim2.new(1, 0, 1, 0)
	frame.BackgroundColor3 = Color3.new(r, g, b)
	
	local txt = Instance.new("TextLabel")
	txt.Parent = frame
	txt.ZIndex = 10
	txt.Text = teamName
	txt.BackgroundTransparency = 1
	txt.Position = UDim2.new(0, 0, 0, -35)
	txt.Size = UDim2.new(1, 0, 10, 0)
	txt.Font = "ArialBold"
	txt.FontSize = "Size12"
	txt.TextStrokeTransparency = 0.5
	txt.BackgroundColor3 = Color3.new(r, g, b)
end

function ToggleESP()
	if ESP ~= true then
		for _, obj in pairs(LocalPlayer.PlayerGui:GetChildren()) do
			if obj.Name == "tracker" and obj:IsA("BillboardGui") then
				obj:Destroy()
			end
		end
		return
	end
	
	local murderer = FindPerson("Murderer")
	local sheriff = FindPerson("Sheriff")
	
	if murderer then
		if Players[murderer.Name].Character:FindFirstChild("Head") then
			MakeNametag(Players[murderer.Name].Character.Head, 255, 0, 0, murderer.Name)
		end
	end
	
	if sheriff then
		if Players[sheriff.Name].Character:FindFirstChild("Head") then
			MakeNametag(Players[sheriff.Name].Character.Head, 255, 0, 0, sheriff.Name)
		end
	end
	
	for _, player in pairs(Players:GetChildren()) do
		if player ~= LocalPlayer then
			if sheriff and murderer then
				if player.Name == murderer.Name or player.Name == sheriff.Name then
					return
				end
				
				if player.Character:FindFirstChild("Head") then
					MakeNametag(player.Character.Head, 0, 255, 0, player.Name)
				end
			end
		end
	end
end

function GodMode()
	if LocalPlayer.Character then
		if LocalPlayer.Character:FindFirstChild("Humanoid") then
			LocalPlayer.Character.Humanoid.Name = "1"
		end
		
		local l = LocalPlayer.Character["1"]:Clone()
		l.Parent = LocalPlayer.Character
		l.Name = "Humanoid"
		wait(0.1)
		LocalPlayer.Character["1"]:Destroy()
		workspace.CurrentCamera.CameraSubject = LocalPlayer.Character.Humanoid
		LocalPlayer.Character.Animate.Disabled = true
		wait(0.1)
		LocalPlayer.Character.Animate.Disabled = false
	end
end

function OnInputBegan(input, gameProcessedEvent)
	if input.UserInputType == Enum.UserInputType.Keyboard then
		local kc = input.KeyCode
		if kc == Enum.KeyCode.Q then
			ESP = not ESP
			ToggleESP()
		elseif kc == Enum.KeyCode.E then
			NoClip = not NoClip
			ToggleNoClip()
		elseif kc == Enum.KeyCode.X then
			XRay = not XRay
			ToggleXray()
		elseif kc == Enum.KeyCode.M then
			FindMurderer()
		elseif kc == Enum.KeyCode.N then
			FindSheriff()
		elseif kc == Enum.KeyCode.G then
			GodMode()
		elseif kc == Enum.KeyCode.H then
			InfiniteJump = not InfiniteJump
		elseif kc == Enum.KeyCode.LeftShift then
			LocalPlayer.Character.Humanoid.WalkSpeed = 60
		elseif kc == Enum.KeyCode.LeftControl then
			TeleportTo(Mouse.Hit.p)
		end
	end
end

function OnInputEnded(input, _)	
	if input.UserInputType == Enum.UserInputType.Keyboard and input.KeyCode == Enum.KeyCode.LeftShift then
		if LocalPlayer.Character:FindFirstChild("Humanoid") then
			LocalPlayer.Character.Humanoid.WalkSpeed = 16
		end
	end
end

UserInputService.JumpRequest:connect(function()
	if not InfiniteJump then return end
	LocalPlayer.Character:FindFirstChildOfClass("Humanoid"):ChangeState("Jumping")
end)

UserInputService.InputBegan:Connect(OnInputBegan)
UserInputService.InputEnded:Connect(OnInputEnded)
workspace.ChildAdded:Connect(GunDropEvent)

SendNotification({
	Title = "mm2hax",
	Text = "mm2hax v1.0.0 loaded",
	Duration = 10,
	Button1 = "yay!"
})