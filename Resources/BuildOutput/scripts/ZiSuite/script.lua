local Players = game:GetService("Players")
local StarterGui = game:GetService("StarterGui")
local RunService = game:GetService("RunService")
local UserInputService = game:GetService("UserInputService")
local LocalPlayer = Players.LocalPlayer
local Mouse = LocalPlayer:GetMouse()

NoClip = false
XRay = false
InfiniteJump = false
RunService.Stepped:connect(function()
	if NoClip then
		LocalPlayer.Character.Humanoid:ChangeState(11)
	end
end)

function SendNotification(data)
	StarterGui:SetCore("SendNotification", data)
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

function TeleportTo(position)
	LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(Vector3.new(position.x, position.y + 7, position.z))
end

function OnInputBegan(input, gameProcessedEvent)
	if input.UserInputType == Enum.UserInputType.Keyboard then
		local kc = input.KeyCode
		if kc == Enum.KeyCode.E then
			NoClip = not NoClip
			ToggleNoClip()
		elseif kc == Enum.KeyCode.X then
			XRay = not XRay
			ToggleXray()
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

SendNotification({
	Title = "cooldude suite",
	Text = "cooldudesuite v1.0.0 loaded",
	Duration = 10,
	Button1 = "yay!"
})